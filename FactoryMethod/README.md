# Factory Method
Thuộc nhóm các Creational pattern
## Overview
- **Factory Method** cung cấp một interface trong superclass để tạo ra các đối tượng, nhưng cho phép các subclasses thay đổi loại đối tượng cụ thể sẽ được tạo ra. 

- Đây là cách giúp các lớp con quyết định đối tượng nào sẽ được khởi tạo mà không làm thay đổi mã của lớp cha.

## Cấu trúc
  - **Product:** Định nghĩa interface hoặc lớp trừu tượng mà các đối tượng được tạo bởi Factory Method phải tuân theo. 
  
  - **Concrete Product:** Các lớp cụ thể triển khai từ Product. Đây là các đối tượng được tạo bởi các lớp con thông qua Factory Method. 
  
  - **Creator:** Lớp cơ sở chứa Factory Method. Phương thức này trả về một đối tượng thuộc kiểu Product. 
  
  - **Concrete Creator:** Các lớp con của Creator, triển khai Factory Method để tạo các đối tượng cụ thể. 
  
## Example
### Problem
Giả sử bạn có một hệ thống mà người dùng có thể tạo ra các loại tài liệu khác nhau như **Word Document** và **PDF Document**. Bạn không muốn lớp cha cụ thể hóa loại tài liệu nào sẽ được tạo ra, mà để cho các lớp con quyết định. 

### Thiết kế class
- **Product:** *"Document" interface*

- **Concrete Product:** *"WordDocument" & "PdfDocument" class*

- **Creator:** *"DocumentFactory" abstract class*

- **Concrete Creator:** *"WordDocumentFactory" & "PdfDocumentFactory" class*
 

