# Standard Value Custom Token Extension for Sitecore 9

This extension will allow you to add custom tokens, such as `$lowerName`, to Sitecore for use in Standard Value settings on Data Templates.

## License
[MIT](/LICENSE.md)

## How to install:
- To begin, clone this repo into an existing Sitecore 9, Helix-based Solution under `/src/Foundation/Extension`.
- Build project and ensure NuGet restores missing NuGet packages.
- Copy the contents of `/App_Config` into your primary web project alongside your existing `/App_Config` files.
- Add a reference of this project to your primary web app and rebuild the entire Solution.

## How to use:
- When setting Standard Values on a Data Template, simply use custom tokens (i.e. `$lowerName`) as you would `$name` or any other Standard Value Token.

## Attribution:
- [Richard Seal](https://sitecore.stackexchange.com/a/12404/3838)
- [Søren Engel](https://soen.ghost.io/working-with-custom-tokens-in-sitecore/)

I posted [this question](https://sitecore.stackexchange.com/questions/12402/can-i-modify-standard-values-variables-such-as-name-to-be-all-lowercase) on the Sitecore StackExchange and was given the answer by Richard Seal (link above), which was derived from the post by Søren Engel (link above).
