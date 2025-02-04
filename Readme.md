# GPA Calculator System Design

## Class Diagram

The following class diagram represents the structure of the GPA calculator system, showing the relationship between the `Form1` and `GPACalculator` classes.

```mermaid
classDiagram
    class GPACalculator {
        +double gpa_sum
        +int n
        +double gpa_min
        +double gpa_max
        +setGPA(gpa: double)
        +getMaxGPA() : double
        +getMinGPA() : double
        +getGPAX() : double
        +getStudentCount() : int
    }

    class Form1 {
        +GPACalculator gPACalculator
        +TextBox tbInputGpa
        +TextBox tbGpax
        +TextBox tbGpaMax
        +TextBox tbGpaMin
        +TextBox tbStudentCount
        +Button btnAdd
        +Button btnClear
        +btnAdd_Click(sender: object, e: EventArgs)
        +btnClear_Click(sender: object, e: EventArgs)
        +UpdateDisplay()
    }

    GPACalculator "1" o-- "*" Form1 : uses
    Form1 "1" o-- "1" GPACalculator : contains
