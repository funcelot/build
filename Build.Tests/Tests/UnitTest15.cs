﻿using Xunit;
using Build;

namespace TestSet15
{
    public static class UnitTest
    {
        [Fact]
        public static void Method1()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            var sql = (SqlDataRepository)container.CreateInstance("TestSet15.SqlDataRepository");
            Assert.NotNull(sql);
        }

        [Fact]
        public static void Method10()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var srv = (ServiceDataRepository)container.CreateInstance("TestSet15.ServiceDataRepository(TestSet15.SqlDataRepository)");
            var sqlRepository = srv.Repository as SqlDataRepository;
            Assert.Equal(2018, sqlRepository.PersonId);
        }

        [Fact]
        public static void Method11()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            var sql = (SqlDataRepository)container.CreateInstance("TestSet15.SqlDataRepository(System.Int32)", new object[] { 2018 });
            Assert.Equal(2018, sql.PersonId);
        }

        [Fact]
        public static void Method12()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<ServiceDataRepository>();
            var sql = (ServiceDataRepository)container.CreateInstance("TestSet15.ServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2018, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method13()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method14()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<WebServiceDataRepository>();
            container.RegisterType<SqlDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method15()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method16()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method17()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<WebServiceDataRepository>();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method18()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method19()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method2()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            var sql = (SqlDataRepository)container.CreateInstance("TestSet15.SqlDataRepository(System.Int32)", 2018);
            Assert.NotNull(sql);
        }

        [Fact]
        public static void Method20()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeInstantiation = false });
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method21()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            //Instantiation reqires SqlDataRepository to be resolved
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)"));
        }

        [Fact]
        public static void Method22()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false, UseDefaultTypeInstantiation = false });
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            //Instantiation reqires SqlDataRepository to be resolved
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)"));
        }

        [Fact]
        public static void Method23()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions());
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method24()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeAttributeOverwrite = false });
            container.RegisterType<WebServiceDataRepository>();
            Assert.Throws<TypeRegistrationException>(() => container.RegisterType<SqlDataRepository>());
        }

        [Fact]
        public static void Method25()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeAttributeOverwrite = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method26()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeAttributeOverwrite = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method27()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeAttributeOverwrite = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method28()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method29()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.Lock();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method3()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = (ServiceDataRepository)container.CreateInstance("TestSet15.ServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.NotNull(sql.Repository);
        }

        [Fact]
        public static void Method30()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false, UseValueTypes = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>(typeof(SqlDataRepository));
            container.Lock();
            var sql = (WebServiceDataRepository)container.GetInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method31()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false, UseValueTypes = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>("TestSet15.SqlDataRepository");
            container.Lock();
            var sql = (WebServiceDataRepository)container.GetInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)");
            Assert.Equal(2019, ((SqlDataRepository)sql.Repository).PersonId);
        }

        [Fact]
        public static void Method32()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.Lock();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)", typeof(SqlDataRepository).ToString());
            Assert.Null(sql.Repository);
        }

        [Fact]
        public static void Method33()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.Lock();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)", typeof(SqlDataRepository));
            Assert.Null(sql.Repository);
        }

        [Fact]
        public static void Method34()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.Lock();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)", typeof(IPersonRepository));
            Assert.Null(sql.Repository);
        }

        [Fact]
        public static void Method35()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.Lock();
            var sql = (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)", typeof(IPersonRepository).ToString());
            Assert.Null(sql.Repository);
        }

        [Fact]
        public static void Method36()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.Lock();
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)", typeof(int).ToString()));
        }

        [Fact]
        public static void Method38()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.Lock();
            Assert.Throws<TypeInstantiationException>(() => (WebServiceDataRepository)container.CreateInstance("TestSet15.WebServiceDataRepository(TestSet15.SqlDataRepository)", typeof(int)));
        }

        [Fact]
        public static void Method39()
        {
            //TestSet15
            var container = new Container(new TypeBuilderOptions { UseDefaultTypeResolution = false });
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            container.Lock();
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance("TestSet15.ErrorWebServiceDataRepository(TestSet15.SqlDataRepository)", typeof(SqlDataRepository).ToString()));
        }

        [Fact]
        public static void Method4()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var srv = (ServiceDataRepository)container.CreateInstance("TestSet15.ServiceDataRepository(TestSet15.IPersonRepository)");
            Assert.NotNull(srv);
        }

        [Fact]
        public static void Method5()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var p = (IPersonRepository)null;
            var srv = container.CreateInstance<ServiceDataRepository>(p);
            Assert.NotNull(srv);
        }

        [Fact]
        public static void Method6()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = container.CreateInstance<SqlDataRepository>();
            var srv = container.CreateInstance<ServiceDataRepository>(new object[] { sql });
            Assert.NotNull(srv.Repository);
        }

        [Fact]
        public static void Method7()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = container.CreateInstance<SqlDataRepository>(new object[] { 0 });
            var srv = container.CreateInstance<ServiceDataRepository>(new object[] { sql });
            var sqlRepository = srv.Repository as SqlDataRepository;
            Assert.NotNull(sqlRepository);
        }

        [Fact]
        public static void Method8()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = container.CreateInstance<SqlDataRepository>(new object[] { (int)Database.WebService });
            var srv = container.CreateInstance<ServiceDataRepository>(new object[] { sql });
            var sqlRepository = srv.Repository as SqlDataRepository;
            Assert.Equal(1, sqlRepository.PersonId);
        }

        [Fact]
        public static void Method9()
        {
            //TestSet15
            var container = new Container();
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance<SqlDataRepository>(new object[] { Database.SQL }));
        }
    }
}