using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Client;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;


namespace OTGStreamToolUserSide
{
    public class ResponseType
    {
        public TournamentType? Tournament { get; set; }
    }
    public class TournamentType
    {
        public int Id { get; set; }
        public List<StreamQueueType>? streamQueue { get; set; }
    }

    public class StreamQueueType
    {
        public StreamType? stream { get; set; }
        public List<SetsType>? sets { get; set; }
    }

    public class StreamType
    {
        public string? streamSource { get; set; }
        public string? streamName { get; set; }
    }

    public class SetsType
    {
        public string? id { get; set; }
        public List<SlotsType>? slots { get; set; }
    }

    public class SlotsType
    {
        public string? id { get; set; }
        public EntrantType? entrant { get; set; }
    }

    public class EntrantType
    {
        public string? id { get; set; }
        public string? name { get; set; }
        public List<ParticipantType>? participants { get; set; }
    }

    public class ParticipantType
    {
        public string? id { get; set; }
        public string? gamerTag { get; set; }
        public string? prefix { get; set; }
    }

    internal class SmashGG
    {
        public async Task<TournamentType> getStreamPlayers(string tournamentSlug, string authToken)
        {
            var graphQLClient = new GraphQLHttpClient("https://api.smash.gg/gql/alpha", new NewtonsoftJsonSerializer());
            graphQLClient.HttpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer" + authToken);

            var streamQueueRequest = new GraphQLRequest
            {
                Query = @"query StreamQueueOnTournament($tourneySlug: String!) {
                    tournament(slug: $tourneySlug) {
                        id
                        streamQueue {
                            stream {
                                streamSource
                                streamName
                            }
                            sets {
                                id
                                slots{
                                    id
                                    entrant{
                                        id
                                        name
                                        participants{
                                            id
                                            gamerTag
                                            prefix
                                        }
                                    }
                                }
                            }
                        }
                    }
                },",
                OperationName = "StreamQueueOnTournament",
                Variables = new
                {
                    tourneySlug = tournamentSlug,
                }


            };

            GraphQLResponse<ResponseType> streamQueueResponse = await graphQLClient.SendQueryAsync<ResponseType>(streamQueueRequest);


            return streamQueueResponse.Data.Tournament;
        }
    }
}
