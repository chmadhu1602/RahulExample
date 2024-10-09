Feature: TestFeatureDependencyInjection

Background: Pre-Condition
	# Given Stpe
	Given User is at Home Page
	And File a Bug should be visible
@Tag2
Scenario: Login scenario of BugZilla
	# Steps - A Given Step
	When I click on File a Bug Link
	Then User should be at Login Page
	When I provide the "chmadhu1602@bugzilla.com", "PASSWORD" and click on Login button
	Then User Should be at Enter Bug page
	When I click on Logout button
	Then User should be logged out and should be at Home Page
