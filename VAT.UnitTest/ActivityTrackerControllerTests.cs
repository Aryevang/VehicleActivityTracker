using Xunit;
using FakeItEasy;
using VAT.api.AbstractServices;
using VAT.api.Models;
using VAT.api.Controllers;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace VAT.UnitTest
{
   public class ActivityTrackerControllerTests
   {
      [Fact]
      public async Task GetAllData_Returns_The_Correct_Number_of_Records()
      {
         //Given
         int dataCount = 5;
         var fakeData = A.CollectionOfDummy<VMT_County>(dataCount).AsEnumerable();

         var dataStore = A.Fake<IActivityTracker<VMT_County>>();
         A.CallTo(() => dataStore.Get_All_dataAsync()).Returns(Task.FromResult(fakeData));
         var controller = new ActivityTrackerController(dataStore);

         //When
         var actionResult = await controller.GetAllData();

         //Then
         var result = (OkObjectResult)actionResult;
         var returnedData = (IEnumerable<VMT_County>)result.Value;
         Assert.Equal(dataCount, returnedData.Count());
      }

      //This test shoud fail :)
      [Fact]
      public async Task Get_find_Requested_Info()
      {
         var idToFind = 1;
         var fakeData = A.Dummy<VMT_County>();

         var dataStore = A.Fake<IActivityTracker<VMT_County>>();
         A.CallTo(() => dataStore.GetDataAsync(idToFind)).Returns(Task.FromResult(fakeData));
         var controller = new ActivityTrackerController(dataStore);

         var actionResult = await controller.Get(idToFind);

         var result = (OkObjectResult)actionResult;
         var returnedData = (VMT_County)result.Value;
         Console.WriteLine(returnedData);
         Assert.Equal(idToFind, returnedData.ID);
      }
   }
}