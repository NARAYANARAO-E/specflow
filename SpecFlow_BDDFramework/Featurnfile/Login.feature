Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

 Background:LoginPage
	Given User Navigate Loginpage url	
	And  user gives username and passsword
	When user clicks loginbtn
	Then user logged sucessfully

	Scenario: Adminpage		
	Given user navigates admin and add page
	And user gives userrole,empname,username,status,password,cnfpassword,
	When user clicks savebtn
   Then user data save sucessfully

   Scenario: AdminConfig_Socailmedia	
	Given user navigates admin and configration and Social Media Authentication and add page
	And user gives type name,url,Redirecturl,clientid,clientScerect,DevelopementKey
	When user clicks Save
   Then user data save sucessfull

   Scenario: Adminconfig_EmailConfig
   Given  user clicks adminbtn and configration and emailconfigration and editbtn and mail,sendmethod,sendtestmail,testEmailaddress
   And user gives SMTPHost,SMTPPort,smtpauthenticationNO,smtpautYES,smtpuser,smtpPwd,RadiobtnNo,RadiobtnSSl,RadioTLS,sendTestMail,TestEmailAddress
   When user clicks EmailcongSavebtn
   Then user EmailconfigData save sucessfully


 