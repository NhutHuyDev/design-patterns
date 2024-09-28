# Abstract Factory 
Thuộc nhóm các Creational pattern
## Overview
- **Abstract Factory** cho phép bạn tạo ra **họ các đối tượng liên quan** mà không cần chỉ rõ lớp cụ thể của chúng.
  
- Mẫu này định nghĩa một giao diện để tạo ra các đối tượng thuộc nhiều loại khác nhau, nhưng để việc quyết định cụ thể các lớp đối tượng đó cho các lớp con.
  
- **Factory Method** và **Abstract Factory** là hai mẫu thiết kế có liên hệ chặt chẽ với nhau trong việc giải quyết bài toán tạo ra các đối tượng.

## Cấu trúc
- **Abstract Product:** Định nghĩa các interface cho các loại đối tượng mà factory có thể tạo ra.

- **Concrete Product:** Các loại đối tượng cụ thể, được tạo ra bởi các Concrete Factory.

- **Abstract Factory:** Định nghĩa một interface để tạo ra *họ các đối tượng khác nhau*.

- **Concrete Factory:** Implement interface của Abstract Factory, cung cấp cách để tạo ra họ các đối tượng cụ thể.

- **Client:** Sử dụng abstract factory để tạo ra các đối tượng, và chỉ làm việc thông qua interface hay abstract product.
  
## Example
### Problem
Giả sử bạn đang phát triển một hệ thống đồ họa và có hai giao diện đồ họa khác nhau, Windows GUI và Mac GUI. Bạn cần một factory để tạo ra các thành phần đồ họa như button và checkbox, mà tất cả các thành phần đều phải tương thích với nhau.

- Tức là, nếu bạn tạo một Windows button, bạn phải tạo một Windows checkbox để chúng làm việc cùng nhau.

### Thiết kế class 
  - **Abstract Product:** *"Button", "Checkbox" interface* 
   
  - **Concrete Product:** *"WindowsButton", "WindowsCheckbox", "MacButton", "MacCheckbox" class*

  - **Abstract Factory:** *"IGUIFactory" interface*
  
  - **Concrete Factory:** *"WindowsFactory", "MacFactory" class* 
   
  - **Client:** *"Application" class*
  
## Abstract Factory và Factory Method:
- Trong **Abstract Factory**, một họ các đối tượng (families of related objects) được tạo ra, và mỗi sản phẩm cụ thể (concrete product) có thể được tạo thông qua một Factory Method. 

- **Factory Method** có thể là phương pháp được sử dụng trong các lớp con của Abstract Factory để tạo các đối tượng mà không cần biết trước lớp cụ thể nào sẽ được khởi tạo.

  - Factory Method là một bước nhỏ hơn của Abstract Factory.
   
- Nếu bạn chỉ cần tạo ra một loại đối tượng duy nhất, bạn có thể sử dụng Factory Method. Tuy nhiên, khi cần tạo ra nhiều loại sản phẩm hoặc các sản phẩm thuộc cùng một họ (family), thì Abstract Factory là lựa chọn thích hợp hơn.

