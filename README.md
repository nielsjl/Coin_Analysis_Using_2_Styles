# Project Coin Analysis

## Overview
This project, `Project-Coin_Analysis_2styles`, is to demonstrate two different coding styles. The first stlye is short and concise and make use of a simple array (contain US currency denominations) and a 'foreach' loop.

## Background (TL;DR)
During a coding/community-of-practice meeting the topic of coding styles came up. The two developers were jokingly raising the practice of using brace-blocks with repetitive identical code for rapid code generation and testing.

## Program.cs
The `Program.cs` file contains the core logic for the coin analysis. Below is a brief overview of its main components:

### 1. Data Loading
The program starts by reading a decimal value from the console.

### 2. Data Processing
Once the data is loaded, it is validated and converted to an integer value representing cents (pennies). It is then processed using  two methods that are functionally the same, but expressed in two different coding styles.

### 3. Analysis
The two different coding styles:
1. Coin/denomination analysis using an array of denominations and a foreach-loop.
2. Coin/denomination analysis using brace-blocks with the verbatim code in each brace-block.

### 4. Output
The result of each analysis is output to the console. For example when the decimal value of 987.65 is entered then the output will look like this:

    ```
    Amount in cents: 98765
    Coin Analysis Using A Foreach Loop:
    Result:
    9 x $100 bill(s)
    1 x $50 bill(s)
    1 x $20 bill(s)
    1 x $10 bill(s)
    1 x $5 bill(s)
    2 x $1 bill(s)
    2 x $0.25 coin(s)
    1 x $0.10 coin(s)
    1 x $0.05 coin(s)

    Time taken for analysis: 1229 ms
    Coin Analysis Using Brace Blocks:
    Result:
    9 x $100 bill(s)
    1 x $50 bill(s)
    1 x $20 bill(s)
    1 x $10 bill(s)
    1 x $5 bill(s)
    2 x $1 bill(s)
    2 x $0.25 coin(s)
    1 x $0.10 coin(s)
    1 x $0.05 coin(s)

    Time taken for analysis: 960 ms
    ```

### 5. Error Handling
The program includes simple error handling for data loading.

## How to Run
To run the program, follow these steps:
1. Ensure you have the .NET SDK installed.
2. Ensure you hasve VS Code installed.
3. Navigate to the project directory using MS Windows File Explorer.
4. Open the VS Code Workspace file (file with the extension ".code-workspace").
    ```
    sh
    dotnet run
    ```

## Dependencies
The project relies on the following dependencies:
- .NET Core 8.0.x

## Contributing
Contributions are welcome! Please fork the repository and submit a pull request with your changes.

## License
This project has no license it is public domain and can be freely misused and abuse as any software developer can see fit to do to it. 🤣
