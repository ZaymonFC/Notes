---
title: PM and Organization Onboarding
author: Zaymon Foulds-Cook
date: 5th June 2019
description: Thought process during the ORG/PM onboarding feature development.
---

# PM and Org Onboarding

## Web Controllers
Something needs to be done about the web controller. Currently the real-estate controller has a lot of routes that I rather wish were shared among other controllers.

It would be nice if the route controllers had the routes listed out and then routed to the appropriate handler function.
```fsharp
this.get.["route/path", true] <- automatic (fun c (model: MODEL) -> handlerFunc c model)
this.get.["route2/path", true] <- automatic (fun c (model: MODEL) -> handlerFunc2 c model)
this.get.["route3/path", true] <- automatic (fun c (model: MODEL) -> handlerFunc3 c model)
```

We'd like to get to something like this.
```fsharp
route "system/administration/"
  POST "organisations" // Add new
  GET  "organisations" // Organisation combobox
  POST "organisations/{id}/keep-the-lights-on" // Enable KTLO after onboarding

  POST "organisations/{id}/property-me/enable"
  POST "organisations/{id}/property-me/disable"
  POST "property-managers/{id}/property-me/enable"
  POST "property-managers/{id}/property-me/disable"
      
  POST "organisations/{id}/products/enabled"
  POST "organisations/{id}/products/removed"
  
  POST "property-managers" // Invite PM
```

I wonder if this should be one controller or one for organizations and one for property managers?

Currently the `RealEstate` controller is a mess. 1000 lines with a bunch of routes that shouldn't logically be collected together. Hmm