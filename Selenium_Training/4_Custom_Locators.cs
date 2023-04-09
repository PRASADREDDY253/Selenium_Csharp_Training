using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Selenium_Training
{
    internal class _4_Custom_Locators
    {
        [Test]
        public void CustomLoatorsTest()
        {
            // Custom Locators -2 
            // 1.Xpath
            // a.Absolute XPath  --> /html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]
            // /html/body/div[1]/div[3]/form/div[1]/div[1]/div[4]/center/input[1]

            //  This is not recommended its unsatable-->if developer introduced any changes/features ,A,Xpath will be broken

            // b.Relative Xpath --> //input[@type='email']
            // Xpath options
            // a.and --> //input[@autocomplete='off' and @type='text'] 
            // b.or  --> //input[@autocomplete='on' or @type='text']
            // c.contains()  --> //input[contains(@placeholder,'.com')]
            // d.starts-with()  --> //input[starts-with(@placeholder,'name')
            // f.text() --> //button[contains(text(),'Submit')]

            //Xpath -axes ->Tools ->Selecorhub ->Dynamic element xpaths
            //1.self
            //  parent::tagname   or /..
            //  child::tagname  or /
            //  ancestor
            //descendant
            //following
            //following-sibling
            //preceding
            //preceding-sibling


            //2.CSS Selector:

            //1.tag id   --> tagname#Id or #Id ex:#userName
            //2. tag class  -->tagname.classname or .classname ex: .text-field-container
            //3.tag attribute -->tagname[attribute=value] ex: div[class=text-field-container]
            //4.tag class attribute -->tagname.classname[attribute=value] ex: .form-control[id = 'permanentAddress']

    }
    }
}
