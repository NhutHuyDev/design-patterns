# Strategy
Thuộc nhóm các Behavioral pattern
## Overview
- **Strategy pattern** cho phép định nghĩa một **họ các thuật toán**, đóng gói mỗi thuật toán trong một lớp riêng, và có thể thay thế các lớp này cho nhau trong quá trình thực thi.
- Mẫu này tạo ra sự linh hoạt và tách biệt mã nguồn của chương trình chính khỏi các chi tiết triển khai của các thuật toán, cho phép chuyển đổi giữa các hành vi khác nhau.

## Cấu trúc
- **Strategy:** Định nghĩa interface hoặc lớp trừu tượng mà các thuật toán (chiến lược) phải tuân theo.

- **Concrete Strategy:** Các lớp cụ thể triển khai từ Strategy. Đây là các lớp chứa các thuật toán hoặc hành vi cụ thể.

- **Context:** Lớp chính sử dụng các chiến lược. Nó chứa tham chiếu đến một đối tượng thuộc kiểu Strategy và thực hiện các hành vi thông qua đối tượng này.

## Example
### Problem
Bạn có một hệ thống bán vé (ticket system). Bạn cần áp dụng các chiến lược khuyến mãi khác nhau để tính giá vé. Các chiến lược khuyến mãi có thể bao gồm:
  
- NoDiscountStrategy: Không có giảm giá.
  
- QuarterDiscountStrategy: Giảm giá 25%.
  
- HalfDiscountStrategy: Giảm giá 50%.

### Thiết kế class
- **Strategy:** *"IPromoteStrategy" interface*
  
- **Concrete Strategy:** *"NoDiscountStrategy", "QuarterDiscountStrategy", "HalfDiscountStrategy" class*

- **Context:** *"Ticket" class*
