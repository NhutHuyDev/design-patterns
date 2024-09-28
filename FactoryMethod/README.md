# Factory Method
Thuộc nhóm các Creational pattern
## Overview
**Factory Method** được sử dụng để tạo các đối tượng mà không cần chỉ định lớp chính xác của đối tượng cần tạo bằng cách cung cấp một inteface để tạo các đối tượng trong một lớp cha và các lớp con sẽ quyết định lớp nào sẽ được khởi tạo.

## Cấu trúc
  - **Product:** Định nghĩa interface hoặc abstract class mà các đối tượng được tạo bởi Factory Method phải tuân theo. 
  
  - **Concrete Product:** Các lớp cụ thể implement từ Product. Đây là các đối tượng được tạo bởi các lớp con thông qua Factory Method. 
  
  - **Creator:** Base class chứa *Factory Method*. Phương thức này trả về một đối tượng thuộc kiểu Product. 
  
  - **Concrete Creator:** Các lớp con của Creator, triển khai *Factory Method* để tạo các đối tượng cụ thể. 
  
## Example
### Problem
Giả sử bạn có một hệ thống mà người dùng có thể tạo ra các loại tài liệu khác nhau như **Word Document** và **PDF Document**. Bạn không muốn lớp cha cụ thể hóa loại tài liệu nào sẽ được tạo ra, mà để cho các lớp con quyết định. 

### Thiết kế class
- **Product:** *"IDocument" interface*

- **Concrete Product:** *"WordDocument" & "PdfDocument" class*

- **Creator:** *"DocumentFactory" abstract class*

- **Concrete Creator:** *"WordDocumentFactory" & "PdfDocumentFactory" class*
 

