using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using Server.Endpoints;

namespace Tests;

public class Tests
{
    private WebApplicationFactory<Program> _factory;

    [OneTimeSetUp]
    public void StartUp()
    {
        _factory = new WebApplicationFactory<Program>();
    }

    [OneTimeTearDown]
    public void TearDown()
    {
        _factory.Dispose();
    }

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TimestampTest()
    {
        var client = _factory.CreateClient();
        var localDate = DateTime.UtcNow;
        var result = client.GetAsync("/timestamp").GetAwaiter().GetResult();
        var content = result.Content.ReadFromJsonAsync<Timestamp>().GetAwaiter().GetResult();

        Assert.That(content, Is.Not.Null);
        Assert.That(content, Is.InstanceOf<Timestamp>());
        Assert.That(content.Date, Is.InstanceOf<DateTime>());
        Assert.That(Math.Abs((localDate - content.Date).TotalSeconds), Is.LessThanOrEqualTo(1));
    }
}