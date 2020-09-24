SystemUtil.Run "iexplore.exe", "http://advantageonlineshopping.com/#/"
wait(2)


Browser("Advantage Shopping").Page("Advantage Shopping").Link("SpeakersCategoryTxt").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").Link("SpeakersCategoryTxt")_;_script infofile_;_ZIP::ssf10.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("buy_now").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("buy now")_;_script infofile_;_ZIP::ssf11.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebEdit("quantity").Set "3" @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebEdit("quantity")_;_script infofile_;_ZIP::ssf12.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("save_to_cart").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("save to cart")_;_script infofile_;_ZIP::ssf13.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").Link("ShoppingCart").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").Link("ShoppingCart")_;_script infofile_;_ZIP::ssf14.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebTable("PRODUCT NAME").Check CheckPoint("PRODUCT NAME_2") @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebTable("PRODUCT NAME")_;_script infofile_;_ZIP::ssf15.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("REMOVE").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("REMOVE")_;_script infofile_;_ZIP::ssf16.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Your shopping cart is").Check CheckPoint("Your shopping cart is empty_2") @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Your shopping cart is")_;_script infofile_;_ZIP::ssf17.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").Link("HOME").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").Link("HOME")_;_script infofile_;_ZIP::ssf18.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").Link("SpeakersCategory").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").Link("SpeakersCategory")_;_script infofile_;_ZIP::ssf1.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("buy_now").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("buy now")_;_script infofile_;_ZIP::ssf2.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebEdit("quantity").Set "3" @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebEdit("quantity")_;_script infofile_;_ZIP::ssf3.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("save_to_cart").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebButton("save to cart")_;_script infofile_;_ZIP::ssf4.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").Link("ShoppingCart").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").Link("ShoppingCart")_;_script infofile_;_ZIP::ssf5.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebTable("PRODUCT NAME").Check CheckPoint("PRODUCT NAME") @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebTable("PRODUCT NAME")_;_script infofile_;_ZIP::ssf6.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("REMOVE").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("REMOVE")_;_script infofile_;_ZIP::ssf7.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Your shopping cart is").Check CheckPoint("Your shopping cart is empty") @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").WebElement("Your shopping cart is")_;_script infofile_;_ZIP::ssf8.xml_;_
Browser("Advantage Shopping").Page("Advantage Shopping").Link("HOME").Click @@ hightlight id_;_Browser("Advantage Shopping").Page("Advantage Shopping").Link("HOME")_;_script infofile_;_ZIP::ssf9.xml_;_
SystemUtil.CloseProcessByName("iexplore.exe")
