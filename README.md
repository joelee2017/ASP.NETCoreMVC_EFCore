# ASP.NETCoreMVC_EFCore
學習記錄

參考官網資料：https://docs.microsoft.com/zh-tw/aspnet/core/data/ef-mvc/intro?view=aspnetcore-5.0

Contoso 大學 Web 應用程式

一、開始使用

- 建立 Web 應用程式
- 設定網站樣式
- EF Core NuGet 套件
- 建立資料模型
- 建立資料庫內容
- 註冊 `SchoolContext`
- 新增資料庫例外狀況篩選準則
- 使用測試資料將 DB 初始化
- 建立控制器和檢視
- 檢視資料庫
- 非同步程式碼

二、建立、讀取、更新及刪除

- 自訂 [詳細資料] 頁面
- 路由傳送資料
- 將註冊新增至 [詳細資料] 檢視中
- 更新 [建立] 頁面
- 更新 [編輯] 頁面
- 建議的 HttpPost Edit 程式碼：讀取及更新
- HttpPost Edit 程式碼的替代方案：建立及連結
- 更新 [刪除] 頁面

三、排序、篩選、分頁及分組

- 新增資料行排序連結
- 將排序功能新增至 Index 方法
- 新增 [搜尋] 方塊
- 將篩選功能新增至 Index 方法
- 將搜尋方塊新增至學生的 [索引] 檢視
- 為 Students 索引新增分頁
- 建立 [關於] 頁面

四、移轉

- 關於移轉
- 卸除資料庫
- 建立初始移轉
- 檢查 Up 和 Down 方法
- 資料模型快照集

五、建立複雜的資料模型

- 自訂資料模型
- DataType 屬性
- StringLength 屬性
- Column 屬性
- 對 Student 實體進行變更
- Required 屬性
- Display 屬性
- FullName 計算屬性
- 建立 Instructor 實體
- CourseAssignments 和 OfficeAssignment 導覽屬性
- 建立 OfficeAssignment 實體
- Key 屬性
- Instructor 導覽屬性
- 修改 Course 實體
- DatabaseGenerated 屬性
- 外部索引鍵及導覽屬性
- 建立 Department 實體
- Column 屬性
- 外部索引鍵及導覽屬性
- 修改 Enrollment 實體
- 多對多關聯性
- CourseAssignment 實體
- 聯結實體名稱
- 複合索引鍵
- 更新資料庫內容
- 關於 Fluent API 替代項目
- 顯示關聯性的實體圖表
- 將測試資料植入資料庫
- 新增移轉
- 變更連接字串

六、讀取相關資料

- 了解如何載入相關資料
- 效能考量
- 建立 Courses 頁面
- 建立 Instructors 頁面