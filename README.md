# README - Hệ thống quản lý trường Cao Đẳng - Đại Học

## 1. Giới thiệu
- Mục tiêu đề tài: Xây dựng hệ thống quản lý trường đại học toàn diện, hỗ trợ quản lý sinh viên, giảng viên, môn học với phân quyền cụ thể.
- Phương pháp: Phát triển ứng dụng phần mềm bằng ngôn ngữ C#, sử dụng kiến trúc 3 lớp, kết nối cơ sở dữ liệu Microsoft SQL Server.
- Đóng góp: Cung cấp công cụ giúp nhà trường quản lý và tra cứu thông tin dễ dàng, đảm bảo tính mở rộng và bảo trì trong tương lai.

## 2. Công nghệ và công cụ sử dụng
- Ngôn ngữ lập trình: C#
- Nền tảng phát triển: .NET Framework
- Cơ sở dữ liệu: Microsoft SQL Server
- Công cụ bổ trợ: Visual Studio, Git/GitHub, ứng dụng DroidCam (biến điện thoại thành đầu đọc mã QR Code).

## 3. Chức năng chính của hệ thống

### 3.1. Đối tượng sử dụng và quyền truy cập
- **Admin**: Quản lý toàn bộ hệ thống, phân quyền, quản lý sinh viên, giảng viên, môn học, tài khoản.
- **Giảng viên**: Đăng ký lịch dạy, xem danh sách sinh viên, nhập điểm, báo cáo.
- **Sinh viên**: Đăng ký/hủy môn học, xem học phí, đánh giá giảng viên, báo cáo sự cố.

### 3.2. Chức năng quản lý Admin
- Quản lý thông tin học viên, giảng viên, môn học: thêm, sửa, xóa, tìm kiếm.
- Quản lý tài khoản đăng nhập và phân quyền.
- Xem báo cáo, đánh giá giảng viên.
- Tìm kiếm, quét mã QR để truy xuất dữ liệu nhanh.

### 3.3. Chức năng giảng viên
- Đăng ký lịch dạy.
- Xem danh sách học viên theo từng môn học.
- Nhập và sửa điểm cho học viên.

### 3.4. Chức năng học viên
- Đăng ký và huỷ đăng ký môn học.
- Xem học phí theo môn học.
- Gửi báo cáo sự cố và đánh giá giảng viên.

## 4. Kiến trúc hệ thống
- Ứng dụng theo kiến trúc 3 lớp: Presentation, Business Logic, Data Access.
- Sử dụng các lớp Transfer Object (DTO) để truyền dữ liệu giữa các tầng.
- Cơ sở dữ liệu SQL Server lưu thông tin sinh viên, giảng viên, môn học, tài khoản, báo cáo, đánh giá.

## 5. Kết quả và thực nghiệm
- Giao diện thân thiện và trực quan cho từng đối tượng người dùng.
- Qua thử nghiệm, hệ thống xử lý hiệu quả các chức năng quản lý, nhập liệu, tìm kiếm, báo cáo.
- Tích hợp quét mã QR Code cho thao tác tìm kiếm nhanh.
- Hệ thống hỗ trợ báo cáo và quản lý đánh giá giảng viên.

## 6. Kết luận
- Đề tài đã xây dựng thành công hệ thống quản lý trường đại học với đầy đủ chức năng và phân quyền.
- Phần mềm giúp nâng cao hiệu quả quản lý học viên và giảng viên, đồng thời giảm thiểu sai sót và tăng tính chính xác trong quản trị dữ liệu.
- Hệ thống có tiềm năng phát triển tiếp các tính năng mở rộng như chatbot, phân tích dữ liệu học tập, báo cáo nâng cao.

---

Bạn có thể dùng phần này làm nội dung cơ bản cho file README.md của dự án quản lý trường đại học, giúp người đọc nhanh chóng hiểu mục tiêu, công nghệ, chức năng và kết quả của hệ thống.
