# Authentication with Cookie Demo

This project demonstrates how to implement authentication in a web application using cookies for session management. It covers setting cookies on login, validating cookies in subsequent requests, and handling logout to clear sessions.

## Features
- User authentication with cookies
- Secure cookie handling (e.g., HttpOnly, Secure, SameSite)
- Storing and retrieving user session data from cookies
- Logging in and logging out functionality
- Backend authentication logic and front-end interaction

## Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/UCN-LANY-Technology3/AuthenticationWithCookieDemo.git
   ```
2. Install the dependencies (if applicable):
   ```bash
   npm install
   ```
3. Start the server (assuming Node.js or any other backend):
   ```bash
   npm start
   ```
4. Open a browser and navigate to `http://localhost:3000` to interact with the demo.

## Usage
### Logging In:
The user provides their credentials (e.g., username and password), and upon successful authentication, the server sets an authentication cookie.

### Example:
```javascript
// On successful login
document.cookie = `token=${authToken}; path=/; HttpOnly; Secure; SameSite=Strict`;
```

### Checking Authentication:
In subsequent requests, the cookie is sent automatically, and the server checks for the valid session token.

### Example Usage:
```javascript
const token = document.cookie.split('; ').find(row => row.startsWith('token=')).split('=')[1];
```

### Logging Out:
Clearing the session and cookie on logout.
```javascript
document.cookie = 'token=; path=/; expires=Thu, 01 Jan 1970 00:00:00 GMT';
```

## Contribution
Contributions are welcome! Feel free to fork this repository, create a new branch, and submit a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more information.
