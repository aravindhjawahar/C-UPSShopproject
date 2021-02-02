package com.tp.spring.web.controller;
/**
 *
 * @author Aravindh
 */
import java.util.Locale;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import com.tp.spring.API.Bonus;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class BonusController {
    protected final Log logger = LogFactory.getLog(getClass());        
    @RequestMapping(method = RequestMethod.GET)
    public String display(Model model) { 
    Bonus bonusCalculation = new Bonus();
    model.addAttribute("command", bonusCalculation);    
    return "/bonus";
}     
    
   @RequestMapping(value = "result",method = RequestMethod.POST)
      public String addStudent(@ModelAttribute("command")Bonus bonusCalculation, ModelMap model) {
      model.addAttribute("ssn", bonusCalculation.getSsn());
      model.addAttribute("multiplier", bonusCalculation.getMultiplier());
      return "/result";
   }

}