## Purpose ##

This sample is used to demonstrate the usage of Castle.Windsor DI container with NLog facility.

### `TypedFactoryFacility` ###

Facility is the way for Castle.Windsor to extend itself. Two basic facilities: [TypedFactoryFacility](https://github.com/castleproject/Windsor/blob/master/docs/typed-factory-facility.md) and StartableFacility.

`TypedFactoryFacility` provides automatically generated Abstract Factories according to a given factory interface. The factory interface provides information to the generated factory for retrieving required services from the DI container. `ITypedFactoryComponentSelector` decides how to [map calls to th typed factory to container's arugments](https://github.com/castleproject/Windsor/blob/master/docs/typed-factory-facility-interface-based.md#mapping-calls-to-typed-factory-to-kernels-arguments). 

