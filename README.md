
# Banking Application

This project is a banking application designed to provide a secure, scalable, and enterprise-grade platform for managing financial transactions. It combines a .NET Core backend with either a React frontend, and leverages a relational database (PostgreSQL) to ensure data integrity and compliance with financial standards. The goal of the system is to enable core banking functionalities such as user authentication, account management, transaction processing, and reporting, while maintaining strict adherence to security, reliability, and ACID-compliant database operations.


## Tech Stack

**Client:** React
- This is because it provides a Modern, fast, JavaScript-based fronted.

**Server:** ASP.Net Core
- Provides built-in support for authenicatio, authorization, and a secure APIs.

**Database:** PostgreSQL

- A Relational Database ensures financial-grade data integrity.


## API Reference

#### Get all items

```http
  GET /api/items
```

| Parameter | Type     | Description                |
| :-------- | :------- | :------------------------- |
| `api_key` | `string` | **Required**. Your API key |

#### Get item

```http
  GET /api/items/${id}
```

| Parameter | Type     | Description                       |
| :-------- | :------- | :-------------------------------- |
| `id`      | `string` | **Required**. Id of item to fetch |

#### add(num1, num2)

Takes two numbers and returns the sum.


## Authors

- [Itumeleng](https://www.github.com/MonoxTI)
- [Themba](https://www.github.com/octokatherine)
- [Phenyo](https://www.github.com/octokatherine)
- [Khutso](https://www.github.com/octokatherine)

## Deployment

To deploy this project run

Frontend
```bash
  npm run dev
```
Backend
```bash
  npm run dev
```
