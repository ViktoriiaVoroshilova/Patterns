using AutoFixture;
using ValidationFactory;
using ValidationFactory.Factories;
using ValidationFactory.Models;

var fixture = new Fixture();
var deltaOneFeeds = fixture.CreateMany<DeltaOneFeed>();
var deltaOneImporter = new FeedImporter<DeltaOneFeed>(new DeltaOneFeedFactory());
deltaOneImporter.Import(deltaOneFeeds);

var emFeeds = fixture.CreateMany<EmFeed>();
var emImporter = new FeedImporter<EmFeed>(new EmFeedFactory());
emImporter.Import(emFeeds);

Console.ReadLine();