using System;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using Autofac;
using Entities.BussinessModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Repository;
using Repository.Interfaces;
using Repository.Repositories;
using Services.Interfaces;

namespace CompanyAppUnitTests
{
    [TestClass]
    public class UnitTest1 : HttpContextBase
    {
        //private readonly ICategoryRepository _categoryRepository;

        //public UnitTest1(ICategoryRepository categoryRepository)
        //{
        //    _categoryRepository = categoryRepository;
        //}

        private IContainer _autoFacContainer;

        private IContainer AutoFacContainer
        {
            get
            {
                if(_autoFacContainer == null)
                {
                    var builder = new ContainerBuilder();
                    builder.RegisterType<CategoryRepository>().As<ICategoryRepository>().InstancePerLifetimeScope();
                    IContainer container = builder.Build();

                    _autoFacContainer = container;
                }

                return _autoFacContainer;
            }
        }

        private ICategoryRepository _categoryRepository
        {
            get
            {
                return AutoFacContainer.Resolve<ICategoryRepository>();
            }
        }

        public UnitTest1()
        {
            HttpContext.Current = FakeHttpContext("http://localhost:26764");
        }

        private HttpContext FakeHttpContext(string url)
        {
            var uri = new Uri(url);
            var httpRequest = new HttpRequest(string.Empty, uri.ToString(),
                                                uri.Query.TrimStart('?'));
            var stringWriter = new StringWriter();
            var httpResponse = new HttpResponse(stringWriter);
            var httpContext = new HttpContext(httpRequest, httpResponse);

            var sessionContainer = new HttpSessionStateContainer("id",
                                            new SessionStateItemCollection(),
                                            new HttpStaticObjectsCollection(),
                                            10, true, HttpCookieMode.AutoDetect,
                                            SessionStateMode.InProc, false);

            SessionStateUtility.AddHttpSessionStateToContext(httpContext, sessionContainer);

            return httpContext;
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Add new category in DB - return true;
            var newCategory = new Category();
            newCategory.Name = "Test";

            var mockRepository = new Mock<ICategoryRepository>();
            mockRepository.Setup(t => t.Add(newCategory)).Returns(false);

            bool result = mockRepository.Object.Add(newCategory);

            Assert.AreEqual(true, result, "Method Add does not work correctly");


            //Add products in that category
            //GetAll Products
            //GetAll Products from that category (1)
            //GetAll Product Names from that category (1)

            //Assert - check if product list is valid
        }

        [TestMethod]
        public void TestMethod2()
        {
            Mock<IReportService> mock = new Mock<IReportService>();
            mock.Setup(t => t.GetSomething(1)).Returns
                (
                    new CustmerCategoriesModel()
                    {
                        CustomerID = 1,
                        CustomerName = "Test Customer"
                    }
                );

            CustmerCategoriesModel result = mock.Object.GetSomething(5);


            //Add new customer in DB
            //...
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Get list of all customers by category     

            
        }
    }
}
