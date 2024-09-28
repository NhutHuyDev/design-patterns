# Singleton
Thuộc nhóm các Creational pattern
## Overview
- **Singleton pattern** đảm bảo rằng một lớp chỉ có duy nhất một instance và cung cấp một điểm truy cập toàn cục đến instance đó. 

- Điều này rất hữu ích trong các tình huống mà ta chỉ cần chia sẻ một nguồn tài nguyên duy nhất trong toàn bộ ứng dụng.

## Cấu trúc của một singleton class 
  - **Private Constructor:** Chặn việc tạo thêm instance từ bên ngoài. 
  
  - **Static Fields (instance):** Lưu trữ duy nhất một instance của lớp.
  
  - **Static Method (GetInstance()):** Cung cấp một điểm truy cập toàn cục để lấy instance đó. 
  
## Example
### Problem
- Một trong những ví dụ phổ biến nhất của Singleton là **Logger**. Một ứng dụng chỉ cần một đối tượng Logger để ghi log cho toàn bộ hệ thống. Việc có nhiều đối tượng Logger có thể dẫn đến rắc rối trong việc quản lý log file, và log không nhất quán.

- Ta thường sẽ sử dụng biến thể **Thread-safe Singleton** cho việc giải quyết bài toán này, vì nó hợp với các ứng dụng multi-threaded.
 
##  Singleton không hiệu quả khi áp dụng với database connection
### Lý do
Nếu bạn chỉ có một kết nối duy nhất đến CSDL, tất cả các thread phải chờ đợi để sử dụng kết nối đó, gây ra tình trạng độ trễ và tranh chấp tài nguyên. Điều này không tối ưu cho các ứng dụng yêu cầu hiệu suất cao khi nhiều thread cần kết nối đến database.

### Giải pháp thay thế: Connection pooling
- Thay vì duy trì một kết nối duy nhất, việc sử dụng **connection pooling** là một giải pháp tối ưu hơn để quản lý kết nối cơ sở dữ liệu trong các ứng dụng đa luồng. 
  
  - Connection pooling là một kỹ thuật phổ biến, trong đó một nhóm các kết nối đến CSDL được tạo ra và tái sử dụng, giúp tối ưu hóa tài nguyên và cải thiện hiệu suất.

- Thông thường, ta sẽ sử dụng Singleton pattern để quản lý **DatabaseManager** thay vì trực tiếp quản lý kết nối đến database.
```
using System;
using System.Data.SqlClient;

public class DatabaseManager
{
    private static DatabaseManager instance;
    private static readonly object lockObject = new object();
    private string connectionString;

    // Private constructor để ngăn không cho khởi tạo trực tiếp
    private DatabaseManager()
    {
        connectionString = "Server=myServer;Database=myDB;User=myUser;Password=myPassword;";
    }

    public static DatabaseManager GetInstance()
    {
        lock (lockObject)
        {
            if (instance == null)
            {
                instance = new DatabaseManager();
            }
        }
        return instance;
    }

    // Thực thi query với connection pooling tự động
    public void ExecuteQuery(string query)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();  // Kết nối từ pool
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0]);
                }
            }
        }
    }
}

```