---

# Simple File Management

**Simple File Management** is a repository showcasing applications developed in both **C** and **C#**, focusing on efficient data handling and file management techniques. This project demonstrates foundational programming concepts, including structured data representation, object-oriented programming (OOP), and file input/output (I/O) operations. 

---

## Project Overview

The repository contains two primary parts:
1. **C Implementation**:
   - A structured approach to managing citizen and nation data using `struct`.
   - Emphasis on file storage and efficient data handling in C.

2. **C# Implementation**:
   - A more advanced approach using OOP concepts.
   - Includes data manipulation via classes and seamless file I/O using the `.NET` libraries.

---

## Features

### C Implementation (`infoCitizenbyStructure.c`)
This program manages data for citizens and their associated nations using `struct`.  
It includes:
- **Hierarchical Data Representation**:
  - Citizen attributes like:
    - Name
    - Age
    - Associated Nation (Name, Language, Region)
- **Data Storage**:
  - Save data to a text file for persistent storage using standard C file operations.
- **Console Interaction**:
  - Input gathering and validation for citizen and nation information.

---

### C# Implementation (`Citizen.cs`, `Program.cs`)
This implementation extends functionality with modern programming techniques. Key features include:
- **Object-Oriented Approach**:
  - Encapsulation of citizen and nation data within `Citizen` and `Nation` classes.
  - Clear separation of concerns with properties for attributes like:
    - Citizen Name and Age
    - Nation Details (Name, Language, and Region)
- **Data Serialization**:
  - Use of file handling methods to read and write data to external files.
- **Dynamic List Management**:
  - Use of lists for storing multiple citizen objects, allowing flexible and scalable data handling.

---

## Code Details

### C Implementation
The C file highlights:
- **Structured Input**:
  - Functions like `GetCitizenData` interactively gather details for citizens and nations.
- **File Output**:
  - Uses standard C file I/O (`fopen`, `fprintf`, etc.) to save the information in a human-readable format.

### C# Implementation
The C# files include:
1. **`Citizen.cs`**:
   - Defines the `Citizen` class with properties for `Name`, `Age`, and an associated `Nation`.
   - The `Nation` class encapsulates details like `Name`, `Language`, and `Region`.
2. **`Program.cs`**:
   - Manages the main program logic:
     - Collecting citizen data via user inputs.
     - Displaying, saving, and retrieving data from external files.
   - Demonstrates robust error handling and validation.

---

## Setup and Usage

### Prerequisites:
- A C compiler (e.g., GCC for C code).
- .NET runtime for C# code (e.g., .NET SDK).

### Steps to Run C Code:
1. Clone the repository:
   ```bash
   git clone https://github.com/GkhanTpz/Simple-File-Management.git
   ```
2. Navigate to the C directory:
   ```bash
   cd Simple-File-Management/C
   ```
3. Compile the C code:
   ```bash
   gcc infoCitizenbyStructure.c -o infoCitizen
   ```
4. Run the application:
   ```bash
   ./infoCitizen
   ```

### Steps to Run C# Code:
1. Navigate to the C# directory:
   ```bash
   cd Simple-File-Management/CSharp
   ```
2. Build and run the C# project:
   ```bash
   dotnet run
   ```

---

## Examples

### C Implementation
**Input Example**:
```text
Enter citizen name: Alice
Enter citizen age: 30
Enter nation name: Wonderland
Enter nation language: English
Enter nation region: Imaginary
```
**Output in File**:
```text
Citizen Name: Alice
Age: 30
Nation: Wonderland
Language: English
Region: Imaginary
```

### C# Implementation
**Input Example**:
```text
Citizen Name: Bob
Age: 40
Nation Name: Neverland
Nation Language: English
Nation Region: Fantasy
```
**Output in File**:
```text
Citizen: Bob
Age: 40
Nation: Neverland
Language: English
Region: Fantasy
```

---

## Improvements and Future Enhancements
- Add search and sort functionality to the C# implementation for easier data retrieval.
- Expand the C implementation to support dynamic memory allocation for managing multiple citizens.
- Include graphical or web-based interfaces for enhanced usability.

---

## License
This project is open source and available under the MIT License.
