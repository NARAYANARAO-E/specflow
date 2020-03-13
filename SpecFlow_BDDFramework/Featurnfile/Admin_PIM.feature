Feature: Admin_PIM
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background:LoginPage
	Given User Navigate Loginpage URL	
	And  user gives userName and passsword
	When user clicks Loginbtn
	Then user logged Sucessfully

	Scenario: Adminpage		
	Given user Navigates admin and add page
	And user gives userRole,empname,username,status,password,cnfpassword,
	When user clicks saveBtn
   Then user data save Sucessfully

   Scenario: PIMpage		
	Given user Navigates PIM and Add page
	And user gives Fname,Mname,Lname,Empid,photograph,logindetail,username,pwd,cnfpwd,status
	When user clicks PIMsaveBtn	
   Then user PIMdata save Sucessfully

