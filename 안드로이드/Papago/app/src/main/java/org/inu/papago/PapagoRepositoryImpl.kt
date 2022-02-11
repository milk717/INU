package org.inu.papago

class PapagoRepositoryImpl(
    private val httpService: PapagoHttpService
) : PapagoRepository{

    override fun transferPapago(
        clientId: String,
        clientSecret: String,
        source: String,
        target: String,
        text: String
    ): ResultTransferPapago {
        return httpService.transgerPapago(clientId, clientSecret, source, target, text).execute().body()!!
    }
}