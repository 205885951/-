using System;
using System.Linq;
using System.Reflection;
using  SqlSugar;
namespace hospital.Models
{
    public class DbContext:IDisposable
    {
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = @"server=.;database=Hospital;uid=sa;pwd=sa",//必填, 数据库连接字符串
                DbType = DbType.SqlServer,         //必填, 数据库类型
                IsAutoCloseConnection = true,       //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                InitKeyType = InitKeyType.Attribute    //默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息
            });
            Show();
        }

        public SqlSugarClient Db;
        public void Show()
        {
            Assembly Ass = Assembly.Load("Car");
            Type[] ts = Ass.GetTypes();
            var con = ts.Where(t => typeof(BaseModels).IsAssignableFrom(t) && t.Name != "BaseModels");
            foreach (var items in con)
            {
                Db.CodeFirst.InitTables(items.Name);
            }
           
        }

        public void Dispose()
        {
          Db.Dispose();
        }
    }
}
