package com.tp.spring.web.controller;
/**
 *
 * @author Aravindh
 */
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import com.tp.spring.API.Bonus;
import com.tp.spring.API.BonusList;
import java.util.ArrayList;
import java.util.List;
import org.springframework.ui.ModelMap;
import org.springframework.web.bind.annotation.ModelAttribute;

@Controller
public class BonusController {

    protected final Log logger = LogFactory.getLog(getClass());        
    @RequestMapping(method = RequestMethod.GET)
    public String display(Model model) { 
    BonusList bonusCalculation = new BonusList();
    List<Bonus> bonusLists = new ArrayList<Bonus>(3);
        for (int i = 0; i < 3; i++) {
           bonusLists.add(new Bonus());
        }
    bonusCalculation.setBonus(bonusLists);
    model.addAttribute("command", bonusCalculation);    
    return "/bonus";
}     
    
   @RequestMapping(value = "result",method = RequestMethod.POST)
      public String addStudent(@ModelAttribute("command")BonusList bonusLists, ModelMap model) {
      model.addAttribute("bonusList",bonusLists);
      return "/result";
   }
}