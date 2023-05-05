# SOLID

# SRP
### Este princípio diz que um módulo devem ter uma única razão para mudar. De acordo com Uncle Bob, isso siginifica que os módulos devem mudar somente em razão de um ator(Usuário/Stackholder)

### Violation
A classe EmployeeViolation está sendo responsável por vários métodos, até ai tudo bem. O problema é que ela está assumindo responsabilidades de diferentes atores
Method | Actor 
--- | --- | 
CalcutePay(int employeeId) | CFO 
ReportHours(int employeeId) | COO
Save(EmployeeModel employee) | CTO

### Solution
Nesse caso, o ideal é dividir as responsabilidades em diferentes classes. Importante dizer que uma classe não necessariamente precisa conter apenas um método, mas sim que precisa conter métodos que façam sentidos estarem na mesma classe


# OCP
### Este princípio diz que um artefato de software devem estar fechados para alteração e abertos para extensão, ou seja, devemos fazer o máximo possível para não alterar nossas classes bases e sim extender suas funcionalidades. 
### Violation

### Solution
