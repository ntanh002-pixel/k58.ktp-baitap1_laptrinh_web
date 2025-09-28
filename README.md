

BÀI TẬP VỀ NHÀ 01:

TẠO SOLUTION GỒM CÁC PROJECT SAU:

DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).

Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE

Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

## Tên đề tài : cá heo theo con trỏ chuột

- Click chọn Create a new project

<img width="533" height="640" alt="image" src="https://github.com/user-attachments/assets/2a41ecf3-0c77-4be6-bddd-64255340182d" />

- Tìm và chọn Class Library (.NET Framework)

<img width="695" height="770" alt="image" src="https://github.com/user-attachments/assets/9d1896fd-b2b7-4f66-b7ca-78fd48cc94f1" />

- Địa chỉ lưu và đặt tên cho project

<img width="1246" height="816" alt="image" src="https://github.com/user-attachments/assets/9956fd0b-d936-4c7d-aa62-93b417e31d1a" />

- Code cho file Dolphin.cs và build để tạo ra dll

<img width="1280" height="604" alt="image" src="https://github.com/user-attachments/assets/8a9e4fd2-bec3-401b-b184-b3dadf451ee8" />

- Tạo project console

<img width="905" height="492" alt="image" src="https://github.com/user-attachments/assets/94459334-dd1b-4763-b198-1b9d4bfdf3f0" />

- Chuột phải vào console project đó 

<img width="905" height="492" alt="image" src="https://github.com/user-attachments/assets/badff8a6-6a10-4bce-8551-8e4f4c9b4bbc" />

- Tích chọn DolphinLib

<img width="974" height="675" alt="image" src="https://github.com/user-attachments/assets/e3993395-58b1-4537-814d-49dada65adf1" />

- Code cho program.cs trong project console đó 

<img width="1261" height="563" alt="image" src="https://github.com/user-attachments/assets/e178aedf-663b-4c9b-bedd-bdda15acdc97" />

- Ta được 4 project đó 

<img width="387" height="380" alt="image" src="https://github.com/user-attachments/assets/7686842a-240c-4582-a511-c2f55b10b1d4" />

- Chạy kết quả console

<img width="1475" height="777" alt="image" src="https://github.com/user-attachments/assets/0382bca9-dcd9-4aee-a0e5-e4a321fe4d99" />

- Chạy kết quả Winform

<img width="996" height="776" alt="image" src="https://github.com/user-attachments/assets/7bf30a07-c4af-40ba-9951-ff25479d2f9b" />

- Chạy kết quả webform

<img width="1908" height="1006" alt="image" src="https://github.com/user-attachments/assets/a7bdf968-edd3-4846-a8ed-9842e8d8b956" />

