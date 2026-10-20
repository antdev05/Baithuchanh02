using Microsoft.AspNetCore.Mvc;

namespace Baithuchanh2.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            // Giả lập danh sách dữ liệu (thực tế có thể lấy từ Database)
            var danhSachMonHoc = new List<string>
            {
                "Lập trình Web ASP.NET Core",
                "Cơ sở dữ liệu SQL Server",
                "Cấu trúc dữ liệu và giải thuật"
            };

            // Truyền dữ liệu sang View (mặc định sẽ tìm file Default.cshtml)
            return View(danhSachMonHoc);
        }
    }
}