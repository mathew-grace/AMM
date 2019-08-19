Feature: CL01_Item1

First loading, verify the followings:
1. The following sections are included: File Upload, Import, Enrichment, Failed Enrichment, Validation, Failed Validation, Confirminator, Failed Matching, Upload Documents
# login and navigate Confirminator - Documentation menu here to test the "First loading" requirement
Scenario: CL01_Item1
	Given User logins to AMM with credential and see the AMM Direct Accounts Page loaded
	| Username | Password  |
	| Username | Datacopy1 |
	When User navigates to menu item Confirminator - Documentation
	Then User should see all sections are loaded