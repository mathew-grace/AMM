Feature: CL02_Item4
	Click on File Upload to expand it, verify the following:
	4. Data Reference has 2 fields for data entry
	4.1. No records saved, in Edit mode, there is Add Another Record button. Click on the button to bring a modal window displaying Title and Detail fields, allow to enter values and save
	4.2. Has record(s) saved, allow to update the 2 fields of each record and save 

@ConfirminatorDocumentation
Scenario: CL02_Item4
	Given User selects File Upload
	Then Data Reference has two fields for data entries Title and Detail
	# Apply for the case no records saved first, then create one and continue the test with the one
	When There is Add Another Record button. 
	And User clicks on the button to bring a modal window displaying Title and Detail fields
	Then User can changed values of these fields
	| Title         | Detail         |
	| This is Title | This is Detail |
	When There is NO Add Another Record button
	Then User still can changed values of these fields
	| Title         | Detail         |
	| That is Title | That is Detail |