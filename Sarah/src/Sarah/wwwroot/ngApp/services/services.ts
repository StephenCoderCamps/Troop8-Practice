namespace Sarah.Services {
    export class SithService {
        private SithResource;
        constructor(private $resource: ng.resource.IResourceService) {
            this.SithResource = this.$resource("/api/Sith/:id");
        }
        public listSith() {
            return this.SithResource.query();

        }
    }
    angular.module("Sarah").service("SithService", SithService);

    }
