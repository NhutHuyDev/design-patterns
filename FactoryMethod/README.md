# Factory Method
Creational pattern
## Overview
- **Factory Method** cung cấp một interface trong superclass để tạo ra các đối tượng, nhưng cho phép các subclasses thay đổi loại đối tượng cụ thể sẽ được tạo ra. 

- Đây là cách giúp các lớp con quyết định đối tượng nào sẽ được khởi tạo mà không làm thay đổi mã của lớp cha.
## Problem Example
- Giả sử bạn có một hệ thống mà người dùng có thể tạo ra các loại tài liệu khác nhau như **Word Document** và **PDF Document**. Bạn không muốn lớp cha cụ thể hóa loại tài liệu nào sẽ được tạo ra, mà để cho các lớp con quyết định. 
- **Cấu trúc:**
  - **Product:** Định nghĩa interface hoặc lớp trừu tượng mà các đối tượng được tạo bởi Factory Method phải tuân theo. *(Document interface)*
  - **Concrete Product:** Các lớp cụ thể triển khai từ Product. Đây là các đối tượng được tạo bởi các lớp con thông qua Factory Method. *(WordDocument & PdfDocument class)*
  - **Creator:** Lớp cơ sở chứa Factory Method. Phương thức này trả về một đối tượng thuộc kiểu Product. *(DocumentFactory abstract class)*
  - **Concrete Creator:** Các lớp con của Creator, triển khai Factory Method để tạo các đối tượng cụ thể. *(WordDocumentFactory & PdfDocumentFactory class)*
