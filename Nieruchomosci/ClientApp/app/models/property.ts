﻿export class Property {
    constructor();
    constructor(
        public propertyId?: number,
        public type?: string,
        public description?: string,
        public rooms?: number,
        public washer?: boolean,
        public refrigerator?: boolean,
        public iron?: boolean,
        public addressId?: number,
        public ownerId?: number
    ) { }       
};
