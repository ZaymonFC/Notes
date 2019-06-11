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

- I wonder if this should be one controller or one for organizations and one for property managers?
- Maybe the onboarding specific routes should be grouped together since they'll both be serving `cx-movers-admin`.

Currently the `RealEstate` controller is a mess. 1000 lines with a bunch of routes that shouldn't logically be collected together. Hmm.

## Read Models
With the current changes I don't think that there needs to be any significant changes for the read models until further milestones. Some changes that will need to be reflected are:
- PM new naming scheme.

An aside. The read models will need to know how to build state from the old and new events. After further milestones I wonder if it would be feasible to separate legacy / new read models entirely.

## Organization aggregate
Currently the `ProvideEnergyAccountDetails` event is being used to trigger:
- ResponsiblePersonSupplied
- LegalEntityDetailsSupplied
- PhysicalAddressSupplied
And conditionally:
- PostalAddressSupplied

This is going to be an annoying one to replace. Once again do I create a new event and map, or try and massage this one into doing what I want.

*Actually* - It should just be fine to fire off all of those events individually? Since we want KTLO to be a simple toggle.
- Just add an event for

## One shot or request per section?
Should think about if we want everything to be submitted at the end of the wizard or


## Actionable
- Add a command for KTLO since it no longer needs a payload. Have all the events currently spawned from the `ProvideEnergyAccountDetails` command just part of the onboarding flow.
- Decide on how we want the information to flow across the API boundary for onboarding orgs
    - One shot command information - I'm leaning towards this one in the spirit of lean
    - Progressive requests for each wizard section


### Validation Library
Need to create validators for the following things in the validation library:
- [ ] Australian phone number
- [ ] Bank Account Number
- [ ] Bank BSB Number
- [X] Australian ACN


### Other Notes - Thoughts
Why do we have a binding model called empty model?
```fsharp
type EmptyModel() =
    class end
```
I hate it when the architecture forces you to use constructs even when you don't need one. I guess it comes down to an argument of special case versus generic with constraints.

Time to sync up with ben and discuss the questions outlined above.

### PropertyMe Integration
- What does this even mean any more?
- To what capacity will this be supported
- How is it expressed in the system today?


### TODOS
- [ ] Deprecate usage of `CompanyAccountModel` in AdminModels.