﻿using System.Threading.Tasks;
using AspnetBoilerPlateMvcTest1.Models.TokenAuth;
using AspnetBoilerPlateMvcTest1.Web.Controllers;
using Shouldly;
using Xunit;

namespace AspnetBoilerPlateMvcTest1.Web.Tests.Controllers
{
    public class HomeController_Tests: AspnetBoilerPlateMvcTest1WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}