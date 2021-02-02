<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@taglib uri="http://www.springframework.org/tags/form" prefix="form"%>
<%@ page session="false"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN"
    "http://www.w3.org/TR/html4/loose.dtd">
<html>
   <head>
      <title>Bonus Calculation</title>
   </head>
   <body>
      <h1>Bonus Calculation</h1> 
    <form:form action="result.htm" commandName="command" method="post">         
        <table>  
            <tr>
                    <td align="center">Social Security Number</td>
                    <td align="center">Multiplier</td>                          
            </tr>
            	<c:forEach items="${command.bonus}" var="bonus" varStatus="status">           
            <tr>
                    <td><form:input path="bonus[${status.index}].ssn" /></td>
                    <td><form:input path="bonus[${status.index}].multiplier" /></td>
            </tr>    
            <tr>              
            </tr>
            	</c:forEach>
             <td colspan = "2">
                  <input type = "submit" value = "Submit"/>
             </td>
         </table>  
      </form:form>
   </body>  
</html>
