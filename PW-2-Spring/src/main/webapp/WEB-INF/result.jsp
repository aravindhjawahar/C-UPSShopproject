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
         <c:forEach items="${bonusList.bonus}" var="bonus" varStatus="status"> 
         <tr>
            <td>Social Security Number:</td>
            <td>${bonus.ssn}</td>
         </tr>
         <tr>
            <td>Multiplier:</td>
            <td>${empty bonus.multiplier ? "calculated bonus empty" : bonus.multiplier}</td>
         </tr>
         </c:forEach>
      </table>  
   </body>
</html>