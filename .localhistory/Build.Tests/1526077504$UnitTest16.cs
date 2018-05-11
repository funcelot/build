using Xunit;

namespace Build.Tests.TestSet16
{
    public class UnitTest
    {
        IContainer container;
        public UnitTest()
        {
            container = new Container();
        }
        [Fact]
        public void TestSet16_Method1()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            var sql = (SqlDataRepository)container.CreateInstance("Build.Tests.TestSet16.SqlDataRepository");
            Assert.NotNull(sql);
        }
        [Fact]
        public void TestSet16_Method2()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            var sql = (SqlDataRepository)container.CreateInstance("Build.Tests.TestSet16.SqlDataRepository(System.Int32)", 2018);
            Assert.NotNull(sql);
        }
        [Fact]
        public void TestSet16_Method3()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = (ServiceDataRepository)container.CreateInstance("Build.Tests.TestSet16.ServiceDataRepository(Build.Tests.TestSet16.SqlDataRepository)");
            Assert.NotNull(sql.Repository);
        }
        [Fact]
        public void TestSet16_Method4()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var srv = (ServiceDataRepository)container.CreateInstance("Build.Tests.TestSet16.ServiceDataRepository(Build.Tests.TestSet16.IPersonRepository)");
            Assert.NotNull(srv);
        }
        [Fact]
        public void TestSet16_Method5()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var srv = container.CreateInstance<ServiceDataRepository>(0);
            Assert.NotNull(srv);
        }
        [Fact]
        public void TestSet16_Method6()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = container.CreateInstance<SqlDataRepository>();
            var srv = container.CreateInstance<ServiceDataRepository>((IPersonRepository)sql);
            Assert.NotNull(srv.Repository);
        }
        [Fact]
        public void TestSet16_Method7()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = container.CreateInstance<SqlDataRepository>(0);
            var srv = container.CreateInstance<ServiceDataRepository>(sql);
            var sqlRepository = srv.Repository as SqlDataRepository;
            Assert.NotNull(sqlRepository);
        }
        [Fact]
        public void TestSet16_Method8()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var sql = container.CreateInstance<SqlDataRepository>((int)Database.WebService);
            var srv = container.CreateInstance<ServiceDataRepository>((IPersonRepository)sql);
            var sqlRepository = srv.Repository as SqlDataRepository;
            Assert.Equal(1, sqlRepository.RepositoryId);
        }
        [Fact]
        public void TestSet16_Method9()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            Assert.Throws<TypeInstantiationException>(() => container.CreateInstance<SqlDataRepository>(Database.SQL));
        }
        [Fact]
        public void TestSet16_Method10()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            var srv = (ServiceDataRepository)container.CreateInstance("Build.Tests.TestSet16.ServiceDataRepository(Build.Tests.TestSet16.IPersonRepository)");
            var sqlRepository = srv.Repository as SqlDataRepository;
            Assert.Equal(2018, sqlRepository.RepositoryId);
        }
        [Fact]
        public void TestSet16_Method11()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            var sql = (SqlDataRepository)container.CreateInstance("Build.Tests.TestSet16.SqlDataRepository(System.Int32)", 2018);
            Assert.Equal(2018, sql.RepositoryId);
        }
        [Fact]
        public void TestSet16_Method12()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (ServiceDataRepository)container.CreateInstance("Build.Tests.TestSet16.ServiceDataRepository(Build.Tests.TestSet16.SqlDataRepository)");
            Assert.Equal(2018, ((SqlDataRepository)sql.Repository).RepositoryId);
        }
        [Fact]
        public void TestSet16_Method13()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet16.WebServiceDataRepository(Build.Tests.TestSet16.ServiceDataRepository)");
            Assert.Equal(2019, ((ServiceDataRepository)sql.RepositoryA).RepositoryId);
        }
        [Fact]
        public void TestSet16_Method14()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet16.WebServiceDataRepository(Build.Tests.TestSet16.IPersonRepository, Build.Tests.TestSet16.IPersonRepository)");
            Assert.Equal(2020, ((ServiceDataRepository)sql.RepositoryA).RepositoryId);
        }
        [Fact]
        public void TestSet16_Method15()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet16.WebServiceDataRepository(Build.Tests.TestSet16.IPersonRepository, Build.Tests.TestSet16.IPersonRepository)");
            Assert.Equal(2022, ((ServiceDataRepository)sql.RepositoryB).RepositoryId);
        }
        [Fact]
        public void TestSet16_Method16()
        {
            //TestSet16
            container.RegisterType<SqlDataRepository>();
            container.RegisterType<ServiceDataRepository>();
            container.RegisterType<WebServiceDataRepository>();
            var sql = (WebServiceDataRepository)container.CreateInstance("Build.Tests.TestSet16.WebServiceDataRepository(Build.Tests.TestSet16.ServiceDataRepository)");
            Assert.Equal(0, sql.RepositoryId);
        }
    }
}
