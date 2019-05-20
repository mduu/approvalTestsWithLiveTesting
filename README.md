# Approval Tests .Net with VS 2019 Live-Testing

Shows the issue of ApprovalTests .Net with VS 2019 Live-Testing

## To reproduce my issue do the following

1. Clone this repo
1. Open it in VS 2019
1. Restore packages and build the solution
1. Run the unit-tests using the VS Test-Runner => all are green
1. Start the Live-Testing => Test is red with the approved file empty
1. Re-run the test manually using the VS Test-Runner => Test is green again

## Assumption

I guess the problem is with ApprovalTest .Net together with VS Live-Testing and maybe XUnit.
It looks like the test gets copied into a temporary directory but not the approved files.
This also happens if one marks the approved file for "always copy".
