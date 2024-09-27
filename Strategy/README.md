# Strategy pattern
Behavioral pattern
## Overview
- **Strategy pattern** cho phép định nghĩa một **họ các thuật toán**, đóng gói mỗi thuật toán trong một lớp riêng, và có thể thay thế các lớp này cho nhau trong quá trình thực thi.
- Mẫu này tạo ra sự linh hoạt và tách biệt mã nguồn của chương trình chính khỏi các chi tiết triển khai của các thuật toán, cho phép chuyển đổi giữa các hành vi khác nhau.
## Problem Example
Bạn có một hệ thống bán vé (ticket system). Bạn cần áp dụng các chiến lược khuyến mãi khác nhau để tính giá vé. Các chiến lược khuyến mãi có thể bao gồm:
- NoDiscountStrategy: Không có giảm giá.
- QuarterDiscountStrategy: Giảm giá 25%.
- HalfDiscountStrategy: Giảm giá 50%.

Chúng ta sẽ áp dụng Strategy Pattern để hệ thống có thể chọn một trong các chiến lược trên một cách linh hoạt mà không cần thay đổi mã nguồn của hệ thống chính.
