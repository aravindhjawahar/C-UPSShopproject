<%@ taglib prefix="form" uri="http://www.springframework.org/tags/form" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<%@ taglib prefix="fmt" uri="http://java.sun.com/jsp/jstl/fmt" %>
<%@ page session="false"%>
<html>
   <head>
      <title>Bonus Calculation</title>
   </head>
   <body>
      <table>
         <tr>
            <td>Social Security Number:</td>
            <td>${ssn}</td>
         </tr>
         <tr>
            <td>Multiplier:</td>
            <td>${multiplier}</td>
         </tr>
      </table>  
   </body>
</html>