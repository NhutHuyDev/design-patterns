# Decorator
Thuộc nhóm các Structural pattern
## Overview
- **Decorator** cho phép thêm các hành vi mới vào một đối tượng bằng cách **bọc đối tượng đó trong các đối tượng đặc biệt** (decorators) chứa các hành vi mới mà không làm thay đổi mã nguồn của đối tượng gốc. 

- Điều này giúp bạn linh hoạt mở rộng chức năng của đối tượng, phù hợp với **Open/Closed Principle** trong *SOLID* (Open/Closed Principle: Một chương trình nên được phát triển để đạt được sự tối đa hóa trong khả năng mở rộng và giảm thiểu nhu cầu sửa đổi, từ đó tránh những lỗi tiềm ẩn hoặc phá vỡ các chức năng hiện có.)

## Cấu trúc
- **Component:** Định nghĩa một interface chung mà cả đối tượng cơ bản và các decorator đều tuân theo.

- **Concrete Component:** Đối tượng cụ thể mà chúng ta muốn mở rộng chức năng.

- **Decorator:** Base class của các decorator, giữ một tham chiếu đến Component (wrappee) và implement các method của Component.
 
- **Concrete Decorator:** Là các lớp decorator cụ thể, triển khai các chức năng bổ sung cho đối tượng Concrete Component.

## Example
### Problem
- Giả sử, chúng ta có một hệ thống xử lý việc lưu trữ dữ liệu. Chúng ta muốn thêm các tính năng như **nén** và **mã hóa** dữ liệu trước khi lưu trữ. 

- **Decorator** cho phép chúng ta xếp chồng các chức năng này một cách linh hoạt mà không cần thay đổi cấu trúc ban đầu của nguồn dữ liệu.

### Thiết kế class
- **Component:** *IDataSource interface*

- **Concrete Component:** *FileDataSource class*

- **Decorator:** *DataSourceDecorator class*

- **Concrete Decorator:** *CompressionDecorator, EncryptionDecorator class*

