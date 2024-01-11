import environment from "@/environment";

const HttpMethod = {
    GET: "GET",
    POST: "POST",
    DELETE: "DELETE",
    PUT: "PUT",
}

class Fetch {
    baseUrl = environment.BASEURL;

    constructor(baseAPI) {
        this.baseAPI = baseAPI
    }

    headers = {
        "Content-Type": "application/json",
    };

    doFetch = async ({url, method, body = null}) => {
        const apiUrl = `${this.baseUrl}${this.baseAPI}${url !== "" ? "/" + url : ""}`;
        // console.log(apiUrl + "\n--------------------------------------------------");

        const requestOptions = {headers: this.headers, method: method};

        if (body) requestOptions.body = JSON.stringify(body);

        const res = await fetch(apiUrl, requestOptions).catch(err => console.error(err));

        if (res === undefined) throw new Error("RESPONSE UNDEFINED!!!");
        if (!res.ok) throw new Error(res.status.toString());

        return await res.json();
    };


    GET = async (url = "", body = null) =>
        this.doFetch({
            url: url,
            method: HttpMethod.GET,
            body: body
        })

    POST = async (url = "", body = null) =>
        this.doFetch({
            url: url,
            method: HttpMethod.POST,
            body: body
        })

    PUT = async (url = "", body = null) =>
        this.doFetch({
            url: url,
            method: HttpMethod.PUT,
            body: body
        })

    DELETE = async (url = "", body = null) =>
        this.doFetch({
            url: url,
            method: HttpMethod.DELETE,
            body: body
        })
}

class Service extends Fetch {
    constructor(baseApi) {
        super(baseApi);
    }

    findAll = async _ => await this.GET()
    findOptimized = async _ => await this.GET(`optimized`)

    create = async (item) => await this.POST('', item)
    createAll = async (items) => await this.POST('all', items)

    update = async (item) => await this.PUT('', item)
    updateAll = async (items) => await this.PUT('all', items)

    delete = async (item) => await this.DELETE('', item)
    deleteAll = async (items) => await this.DELETE('all', items)
}

class ModuleService extends Service {
    constructor(baseApi) {
        super(baseApi);
    }

    findById = async (id) => await this.GET(`${id}`)

    updateOrCreate = async (item) => await this.PUT('update-create', item)
    updateOrCreateAll = async (items) => await this.PUT('update-create/all', items)

    deleteById = async (id) => await this.DELETE(`${id}`)
}

class AssociationService extends Service {
    constructor(baseApi) {
        super(baseApi);
    }

    findByIds = async (item) => await this.POST(`id`, item)
}

export {ModuleService, AssociationService, Service};
