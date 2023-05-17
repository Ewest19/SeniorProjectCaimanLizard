﻿@Armando_Yanez
@LoggedIn
Feature: CLD200_EditGroup

**As a user, I would like to be able to modify my Watch Party Group so that I can add the link to the TeleParty link so that
others in the group can see it and join.**

This feature will allow the host of the watch party to make modifications to an already existing watch party group, it also
introduces a TeleParty URL field so that other users are able to join the watch party so that they can watch shows with
others in the group via the TeleParty thrid party extension.

Background:
	Given the following users exist
	  | UserName   | Email                 | FirstName | LastName | Password |
	  | TaliaK     | knott@example.com     | Talia     | Knott    | ScotIs#1 |
	  | ZaydenC    | clark@example.com     | Zayden    | Clark    | ScotIs#1 |
	  | DavilaH    | hareem@example.com    | Hareem    | Davila   | ScotIs#1 |
	  | KrzysztofP | krzysztof@example.com | Krzysztof | Ponce    | ScotIs#1 |

Scenario Outline: Users can navigate to the edit page to make changes to their current watch party
	Given I am a user with first name '<FirstName>'
	When I login
		And I go to the details page of the newly created watch party
		And I click on the group options button
		And I click on the edit group button
	Then the page title contains "Edit Group"
	Examples:
	| FirstName |
	| Talia     |
	| Zayden    |
	| Hareem    |
	| Krzysztof |

Scenario Outline: Users can navigate to edit page that is not their own but are unable to make changes
	Given I am a user with first name '<FirstName>'
	When I login
		And I navigate to the "EditExistingWatchParty" page
	Then I should see a header titled "Only the host can make modifications to the Watch Party Group"
	Examples:
	| FirstName |
	| Talia     |
	| Zayden    |
	| Hareem    |
	| Krzysztof |

Scenario Outline: Users can navigate to the edit page and update watch party group even if nothing was updated
	Given I am a user with first name '<FirstName>'
	When I login
		And I go to the details page of the newly created watch party
		And I click on the group options button
		And I click on the edit group button
		And I click on update
	Then I should be redirected to the details page with page title "Group Details"
		And I should see header "Group Details", group title "Movie night", group description "Join one join all", start date "10/15/2024 8:00:00 PM", and TeleParty URL "N/A" have all been updated 
	Examples:
	| FirstName |
	| Talia     |
	| Zayden    |
	| Hareem    |
	| Krzysztof |