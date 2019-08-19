Feature: CL02_Item3
Click on File Upload to expand it, verify the following:
	3. These Overview, Static Data and Process have only one entry field, allow to edit and save

@ConfirminatorDocumentation
Scenario: CL02_Item3
	Given User selects File Upload tab
	Then User sees entries Overview, Static Data and Process
	And  User can changed values of these entries
	| Overview         | StaticData          | Process           |
	| This is Overview | This is Static Data | This is a Process |
