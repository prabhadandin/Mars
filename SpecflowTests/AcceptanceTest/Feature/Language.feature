Feature: Language Tab
	  As a Skill Trader
      I want to be able to Add,update,Delete Languages 
      In order to update my profile details

@automation
Scenario: Add language
	Given I clicked on the profile tab under Profile page
	When I add a new language
	Then that language should be displayed on my listings
	
Scenario: Add Language without Mandatory details
	Given I clicked on the profile tab under Profile page
	When I dont provide a Mandatory language details
	Then i should see the ErrorMessage displayed on screen
    
Scenario: Add 5th language 
	Given I clicked on the profile tab under Profile page
	When I add 5th new language 
	Then i should see the ErrorMessage displayed on screen
	 
Scenario: Add existing language from list
	Given I clicked on the profile tab under Profile page
	When I add existing language from list
	Then i should see  the ErrorMessage displayed on screen
   
Scenario: Add existing language from list with different LanguageLevel
	Given I clicked on the profile tab under Profile page
	When I add existing language but  with different LanguageLevel
	Then i should see the ErrorMessage displayed on screen

@automation
Scenario: Update language 
	Given I clicked on the profile tab under Profile page
	When I  update Language 
	Then that updated language should be displayed on my listings
	 
Scenario: Update language without Mandatory deatails 
	Given I clicked on the Profle tab under Profile page
	When I wont provide Mandatory Language details
	Then i should see the ErrorMessage displayed on screen
	
 Scenario: Update with existing language from list
	Given I clicked on the Profle tab under Profile page
	When  I  update existing Language from list
	Then i should see the ErrorMessage displayed on screen

Scenario: Update with existing language from list with different languagelevel
	Given I clicked on the Profle tab under Profile page
	When  I  update  exitsin Language from list with different LanguageLevel
	Then i should see the ErrorMessage displayed on screen

   
@automation     
Scenario: Delete language 
	Given I clicked on the profile tab under Profile page
	When I delete language 
	Then that language should not be displayed on my listings
	

