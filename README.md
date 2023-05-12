# SistemaContoleRecomendacoes(SCR)

#Sistema de Controle de Recomendaçôes

## Cartas de Recomendações Expedidas

As recomandações Expedidas ou Recebidas devem ser ter o prazo de validade maxima de 6 meses a contar da data da Elaboração

## Registo de Cartas de Recomendação Expedidas

Nome do Membro, Sobre Nome, Data da Recomendação,Data de Validade da Carta, Igreja de Destino, Localidade de Destino,
Numero de Telefone do Membro, Estado da carta(O Estado da carta pode ser: valido, invalido, devolvido), UrldaCartaGerada, Data de Regresso ou Devolução.

## Registo de cartas de Recommendação Recebidas

Nome do Membro, Sobre Nome, Data da Recomendação, Data de Validade da Carta, Igreja de Origem, Localidade da Origem,
Numero de Telefone do Membro, Estado da carta(O Estado da carta pode ser: valido, invalido, devolvido),Morada Actual do Membro, UrlCartaAnexada, Data de Retorno.

### Algumas Regras

A Data de Validade da carta de recomendação Expedida deve ser calculado no sistema adicionando 6 meses a data da recomendação, caso a data de Expiração seja igual ou superior a data actual o estado da carta deve alterar para invalido. -- DONE

Ao Registar uma carta o sistema deve verificar se a data actual é superio a data de validade da Carta, caso seja superior não deve ser possivel Registar a recepção, e quando a data de validade é superior a data actual o sistema deve tambem mudar o estado da Carta de Recomendação recebido. - DONE

Quando o membro Regressa deve ser informado a data do Regresso, ou de retorno para o caso dos membros recebidos, - DONE

Depois que termina a Recomendação Deve ser Gerado um documento em pdf Denominado Carta de Recomendação. -- TODO

caso a Recomendção expedita regressa, ao informa a data de retorno o sistema deve alterar o estado da recomedação para devolvido, essa regra é valido para as cartas de recomendação. - DONE

Se possivel pode monitorar infomando quando tempo falta para as carta activas ficarem desavitvas e tambem podem monitorar quanto tempo quantos dias as cartas estão invalidas. -- TODO

Quando a carta é gerada deve ser guardado no sistema. -- TODO

Quando uma carta é recebida deve ser anexado ao registo de Recepção do Membro, mantendo assim o documento seguro de possiveis extravios. -- TODO

As Recomendações devem ser Listadas em duas categorias [Expedidas e Recebidas], e separadas de acordo ao seu estado e num intervalo de data de acordo o utilizador, as datas em causas a principio deve ser a data de entrata para os Expedidos e a data da recomendação para os Expedidos. -- TODO

O sistema deve Gerar Um documento de Recomendação que será impressa a aasinada e entregue ao membro, e quando o membro regressa pode sim ter a possibilidade de anexar a carta expedida com a assinatura de devilução da igreja visitada. -- TODO

## Prazo de Execução do Codigo

A data prevista por mim para a conclução da primeira fase deste projecto é 01/06/2023 do backEnd sem a parte do Gerar Documentoe e nem fazer anexo.
