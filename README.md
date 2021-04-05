# Trade-Ogre-Alerter
A C# Desktop and SMS alerter utility for the Trade Ogre Exchange

A simple alerter that will alert you via SMS, desktop notifications and or audio alert. 
(SMS alerts require Trilio - https://www.trilio.io/) 

<h2><b><u>Instructions</b></u></h2>

1) Whichever version you want, just change the extension at then end of the following link

Example: 
https://minhaskamal.github.io/DownGit/#/home?url=https://github.com/thevileo/Trade-Ogre-Alerter/tree/main/TradeOgre-v1.0

2) Open the executable, If you are using SMS alerts, input your keys from trilio into the settings. 
3) Set your criteria and click start.


<h2><b><u>Changes</b></u></h2>

<b> V1.0 </b> 
- I seperated the execuatable files and the code files for ease of access(really for me). 
- Disabled resizing of the main form
- Auto Populated first crypto in drop down list to avoid exception errors. 
- SMS alert checkbox is disabled after 1st alert. This is to avoid being mass texted and wasting your trilio balance. Future updates may include something like "stop after x amount of alerts, but I dont really see the need at this time. 
- Added about tab, nothing fancy just alittle bit about how this simple project came into play.
- Updated the getnerva.org hyperlink. Shilling to the max. 

<h2><b><u>FAQ</b></u></h2>
Q: What is the Save buttons used for? 
A: They will save your sell/buy prices and parameters in the event you close out of the application. I found it annoying to re-enter this info. 

Q: What is the SELL/BUY/STRONG BUY used for? 
A: This is for daily trading. It will be an indicator if the current price is greater or less then the inital price. I used this as a reference to find dips I might be interested in that day. 
