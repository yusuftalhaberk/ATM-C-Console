# ATM-CSharp-Console
# ATM Console Uygulaması

Bu proje, C# dilinde yazılmış basit bir **ATM simülasyonu** uygulamasıdır. Kullanıcılar sisteme üye olabilir, giriş yapabilir ve bakiye işlemleri gerçekleştirebilir.

## Özellikler
- 📝 Üye olma (isim, parola, müşteri numarası otomatik oluşturulur)
- 🔑 Giriş yapma (müşteri numarası ve parola doğrulaması)
- 💰 Para yatırma
- 💸 Para çekme
- 📊 Bakiye görüntüleme
- 🚪 Çıkış yapma

## Kullanım
1. Program çalıştırıldığında kullanıcıya menü sunulur:
   - `1` → Üye Ol
   - `2` → Giriş Yap
   - `3` → Çıkış

2. Üye olma sırasında:
   - İsim girilir
   - Parola belirlenir
   - Sistem otomatik müşteri numarası üretir

3. Giriş yapma sırasında:
   - Müşteri numarası girilir
   - Parola doğrulanır
   - Ardından bakiye işlemleri yapılabilir

## Kod Yapısı
- **MusteriHakkında.cs**  
  - Müşteri bilgilerini tutar (isim, parola, müşteri no, bakiye)  
  - Para yatırma ve çekme işlemlerini içerir  

- **Program.cs**  
  - Ana menü ve kullanıcı etkileşimini yönetir  
  - Maksimum 10 müşteri kaydı tutulur  

## Çalıştırma
Proje Visual Studio veya .NET CLI ile çalıştırılabilir:

------------------------------------------------------------------------------------------------------------------------------
Note: The project code and console messages are originally written in Turkish.
# ATM Console Application

This project is a simple **ATM simulation** written in C#. Users can register, log in, and perform balance operations.

## Features
- 📝 Register (name, password, customer number generated automatically)
- 🔑 Login (customer number and password verification)
- 💰 Deposit money
- 💸 Withdraw money
- 📊 View balance
- 🚪 Exit

## Usage
1. When the program starts, the user is presented with a menu:
   - `1` → Register
   - `2` → Login
   - `3` → Exit

2. During registration:
   - Enter your name
   - Set a password
   - The system generates a customer number automatically

3. During login:
   - Enter your customer number
   - Enter your password
   - After successful login, you can perform balance operations

## Code Structure
- **MusteriHakkında.cs**  
  - Stores customer information (name, password, customer number, balance)  
  - Contains deposit and withdrawal methods  

- **Program.cs**  
  - Manages the main menu and user interaction  
  - Limits the system to a maximum of 10 customers  

## Running the Project
You can run the project using Visual Studio or .NET CLI:
