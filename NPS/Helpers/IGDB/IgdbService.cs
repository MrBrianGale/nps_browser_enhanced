using IGDB;
using IGDB.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NPS.Helpers.IGDB
{
    public class IgdbService
    {
        private readonly string _clientId;
        private readonly string _clientSecret;

        private string _accessToken;
        private DateTime _tokenExpiry;

        private IGDBClient _client;

        // Full region mapping (IGDB standard)
        private static readonly Dictionary<string, int> RegionMap = new()
        {
            ["eu"] = 1,
            ["us"] = 2,
            ["na"] = 2,
            ["au"] = 3,
            ["nz"] = 4,
            ["jp"] = 5,
            ["cn"] = 6,
            ["asia"] = 7,
            ["world"] = 8,
            ["kr"] = 9,
            ["br"] = 10
        };

        // Platform mapping for PS3 / PSP / Vita
        private static readonly Dictionary<string, int> PlatformMap = new()
        {
            ["neogeo"] = 79,
            ["ps3"] = 9,
            ["psp"] = 38,
            ["vita"] = 46,
            ["minis"] = 38,
            ["psx"] = 7,
            ["ps2"] = 8,
            ["ps4"] = 48,
            ["psvr"] = 165,
            ["psm"] = 45,
            ["linux"] = 3,
            ["n64"] = 4,
            ["wii"] = 5,
            ["pc"] = 6,
            ["windows"] = 6,
            ["psx"] = 7,
            ["ps1"] = 7,
            ["ps2"] = 8,
            ["ps3"] = 9,
            ["xbox"] = 11,
            ["xbox360"] = 12,
            ["dos"] = 13,
            ["mac"] = 14,
            ["nes"] = 18,
            ["snes"] = 19,
            ["nds"] = 20,
            ["ds"] = 20,
            ["gamecube"] = 21,
            ["gbc"] = 22,
            ["dreamcast"] = 23,
            ["gba"] = 24,
            ["genesis"] = 29,
            ["megadrive"] = 29,
            ["32x"] = 30,
            ["saturn"] = 32,
            ["gb"] = 33,
            ["android"] = 34,
            ["gamegear"] = 35,
            ["3ds"] = 37,
            ["psp"] = 38,
            ["minis"] = 38,
            ["ios"] = 39,
            ["wiiu"] = 41,
            ["psn"] = 45,
            ["psm"] = 45,
            ["vita"] = 46,
            ["psvita"] = 46,
            ["ps4"] = 48,
            ["xbone"] = 49,
            ["xboxone"] = 49,
            ["arcade"] = 52,
            ["atari2600"] = 59,
            ["atari7800"] = 60,
            ["lynx"] = 61,
            ["jaguar"] = 62,
            ["mastersystem"] = 64,
            ["intellivision"] = 67,
            ["colecovision"] = 68,
            ["ouya"] = 72,
            ["steamos"] = 92,
            ["neogeomvs"] = 79,
            ["neogeoaes"] = 80,
            ["web"] = 82,
            ["pcengine"] = 86,
            ["turbografx16"] = 86,
            ["virtualboy"] = 87,
            ["switch"] = 130,
            ["eshop"] = 160,
            ["wmr"] = 161,
            ["oculus"] = 162,
            ["steamvr"] = 163,
            ["psvr"] = 165,
            ["ps5"] = 167,
            ["xboxseries"] = 169,
            ["seriesx"] = 169,
            ["stadia"] = 170,
            ["switch2"] = 508

        };


        public async Task<string> IgdbRequestAsync(string endpoint, string query)
        {
            await EnsureTokenAsync();

            using var http = new HttpClient();
            http.DefaultRequestHeaders.Add("Client-ID", _clientId);
            http.DefaultRequestHeaders.Add("Authorization", $"Bearer {_accessToken}");

            var content = new StringContent(query, Encoding.UTF8, "text/plain");

            var response = await http.PostAsync($"https://api.igdb.com/v4/{endpoint}", content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
        public async Task<T[]> QueryAsync<T>(string endpoint, string query)
        {
            var json = await IgdbRequestAsync(endpoint, query);
            return JsonSerializer.Deserialize<T[]>(json);
        }

        public IgdbService(string clientId, string clientSecret)
        {
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        // Ensures we have a valid Twitch OAuth token
        private async Task EnsureTokenAsync()
        {
            if (!string.IsNullOrEmpty(_accessToken) && DateTime.UtcNow < _tokenExpiry)
                return;

            using var http = new HttpClient();

            var body = new Dictionary<string, string>
            {
                { "client_id", _clientId },
                { "client_secret", _clientSecret },
                { "grant_type", "client_credentials" }
            };

            var response = await http.PostAsync(
                "https://id.twitch.tv/oauth2/token",
                new FormUrlEncodedContent(body)
            );

            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            var doc = JsonDocument.Parse(json);

            _accessToken = doc.RootElement.GetProperty("access_token").GetString();
            int expiresIn = doc.RootElement.GetProperty("expires_in").GetInt32();

            _tokenExpiry = DateTime.UtcNow.AddSeconds(expiresIn - 60); // safety margin

            //_client = IGDBClient.CreateWithDefaults(_clientId, _accessToken);
            _client = IGDBClient.CreateWithDefaults(_clientId, _clientSecret);
        }

        // Main lookup function: name + platform + region
        public async Task<GameData[]> LookupGameAsync(string name, string platform, string region)
        {
            await EnsureTokenAsync();
            int platformId, regionId;
            if (!PlatformMap.TryGetValue(platform.ToLower(), out platformId))
            {
                platformId = -1;
            }
            
            if (!RegionMap.TryGetValue(region.ToLower(), out regionId))
            {
                regionId = -1;
            }

            string query = $@"fields
    id,
    name,
    summary,
    cover.*,
    screenshots.*,
    genres.*,
    game_modes.*,
    involved_companies.*,
    involved_companies.company.*,
    release_dates.*,
    platforms.*,
game_localizations.*;search ""{name}"";";
            List<string> filters = new();

            if (platformId >= 0)
            {
                filters.Add($"release_dates.platform = {platformId}");
            }

            if (regionId >= 0)
            {
                filters.Add($"release_dates.release_region = {regionId}");
            }
            if (filters.Count > 0)
            {
                query += $" where {string.Join(" & ", filters)};";
            }

            query += " limit 20;";

            var games = await QueryAsync<GameData>("games", query);
            
            return games;
        }
    }
        public class GameData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("summary")]
            public string Summary { get; set; }

            [JsonPropertyName("cover")]
            public CoverData Cover { get; set; }

            [JsonPropertyName("genres")]
            public GenreData[] Genres { get; set; }

            [JsonPropertyName("game_modes")]
            public GameModeData[] GameModes { get; set; }

            [JsonPropertyName("screenshots")]
            public ScreenshotData[] Screenshots { get; set; }

            [JsonPropertyName("platforms")]
            public PlatformData[] Platforms { get; set; }

            [JsonPropertyName("release_dates")]
            public ReleaseDateData[] ReleaseDates { get; set; }

            [JsonPropertyName("game_localizations")]
            public GameLocalizationData[] Localizations { get; set; }

            [JsonPropertyName("involved_companies")]
            public InvolvedCompanyData[] InvolvedCompanies { get; set; }
        }

        public class CoverData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("image_id")]
            public string ImageId { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }

        public class GenreData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        public class GameModeData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        public class ScreenshotData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("image_id")]
            public string ImageId { get; set; }

            [JsonPropertyName("url")]
            public string Url { get; set; }
        }

        public class PlatformData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }
        }

        public class ReleaseDateData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("date")]
            public long Date { get; set; }

            [JsonPropertyName("region")]
            public int Region { get; set; }

            [JsonPropertyName("platform")]
            public int PlatformId { get; set; }
        }

        public class GameLocalizationData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("game")]
            public int GameId { get; set; }

            [JsonPropertyName("locale")]
            public string Locale { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("summary")]
            public string Summary { get; set; }

            [JsonPropertyName("region")]
            public int Region { get; set; }
        }

        public class InvolvedCompanyData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("developer")]
            public bool Developer { get; set; }

            [JsonPropertyName("publisher")]
            public bool Publisher { get; set; }

            [JsonPropertyName("company")]
            public CompanyData Company { get; set; }
        }

        public class CompanyData
        {
            [JsonPropertyName("id")]
            public int Id { get; set; }

            [JsonPropertyName("name")]
            public string Name { get; set; }

            [JsonPropertyName("description")]
            public string Description { get; set; }

            [JsonPropertyName("logo")]
            public int LogoId { get; set; }
        }

    }
