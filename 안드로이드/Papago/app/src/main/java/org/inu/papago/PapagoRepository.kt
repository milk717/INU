package org.inu.papago

interface PapagoRepository {
    fun transferPapago(
        clientId: String,
        clientSecret: String,
        source: String,
        target: String,
        text: String
    ): ResultTransferPapago
}