using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableWebApp.Models.Repository;
using TestableWebApp.Models;
using System.Collections.Generic;
using TestableWebApp.Presenters;
using TestableWebApp.Presenters.Results;

namespace TestableWebApp.Tests
{
    [TestClass]
    public class RSVPPresenterTests
    {
        class MockRepository : IRepository
        {
            private List<GuestResponse> mockData = new List<GuestResponse> {
                new GuestResponse {Name = "Person1", WillAttend = true},
                new GuestResponse {Name = "Person2", WillAttend = false}
            };
            public IEnumerable<GuestResponse> GetAllResponse()
            {
                return mockData;
            }
            public List<GuestResponse> GetAllResponses()
            {
                return mockData;
            }
            public void AddResponse(GuestResponse response)
            {
                mockData.Add(response);
            }
        }
        [TestMethod]
        public void Adds_Object_To_Repository()
        {
            // Arrange
            IRepository repo = new MockRepository();
            IPresenter<GuestResponse> target = new RSVPPresenter { repository = repo };
            GuestResponse dataObject =
            new GuestResponse { Name = "TEST", WillAttend = true };
            // Act
            IResult result = target.GetResult(dataObject);
            // Assert
            Assert.AreEqual(repo.GetAllResponse().Count(), 3);
            Assert.AreEqual(repo.GetAllResponse().Last().Name, "TEST");
            Assert.AreEqual(repo.GetAllResponse().Last().WillAttend, true);
        }
    }
}
