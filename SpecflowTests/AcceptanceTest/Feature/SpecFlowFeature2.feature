Feature: AddSkills
	  As a Skill Trader
      I want to be able to update Education that i have
      In order to update my profile details

Background: 
   Given I Logged in Profile Page 

@mytag
Scenario Outline: Add Skill 
    Given I clicked on the Skills tab under Profile page
	When I add new skill'<Skillname>', '<SkillLevel>'	
	Then i should see the skill '<Skillname>'displayed on my listings
	Examples: 
	 | Skillname | SkillLevel |
	 | Java      | Beginner   |
	 | Csharp    | Expert     |
	 | C++         | Expert     |
	 | Python    | Expert     |
	 
Scenario Outline: Add existing Skill from list
    Given I clicked on the Skills tab under Profile page
	When I add existing skill from list
	Then i should see the'<ErrorMessage>'displayed on my listings
Examples: 
    | ErrorMessage | 
    | This Skill Already exists in your skill list  | 
	
Scenario Outline: Add existing Skill from list with different SkillLevel
    Given I clicked on the Skills tab under Profile page
	When I add existing skill from list with different SkillLevel
	Then i should see the'<ErrorMessage>'displayed on my listings
Examples: 
    | ErrorMessage | 
    | This Skill Already exists in your skill list  | 

	 
Scenario Outline: Add Skill without Mandatory details
    Given I clicked on the Skills tab under Profile page
	When I dont provide skill Mandatory details
	Then i should see '<ErrorMessage>'displayed on screen
Examples: 
    | ErrorMessage | 
    | Please Enter Skill and SkillLevel| 
		
	
Scenario: Update Skill 
    Given I clicked on the Skills tab under Profile page
	When I update skill 
	Then i should see updated skill displayed on my listings
	 
Scenario Outline: Update with existing Skill from list
    Given I clicked on the Skills tab under Profile page
	When I update with existing skill  from list
	Then i should see the'<ErrorMessage>'displayed on my listings
	Examples: 
	  | ErrorMessage | 
    | This Skill Already exists in your skill list  | 

Scenario Outline: Update with existing Skill from list with different SkillLevel
    Given I clicked on the Skills tab under Profile page
	When I update with existing skill from list with different SkillLevel
	Then i should see the'<ErrorMessage>'displayed on my listings
	Examples: 
	  | ErrorMessage | 
    | This Skill Already exists in your skill list  | 

Scenario Outline: Update Skill without Mandatory details
    Given I clicked on the Skills tab under Profile page
	When I dont provide skill  Mandatory details
	Then i should see '<ErrorMessage>'displayed on screen
	Examples: 
    | ErrorMessage | 
    | Please Enter Skill and SkillLevel|
	

Scenario Outline: Delete Skill 
    Given I clicked on the Skills tab under Profile page
	When I delete skill '<Skillname>'
	Then i should not see deleted skill '<Skillname>'displayed on my listings
	Examples: 
	 | Skillname | 
	 | AJAX     | 


