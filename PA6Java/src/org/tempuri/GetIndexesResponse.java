/**
 * GetIndexesResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetIndexesResponse  implements java.io.Serializable {
    private org.tempuri.GetIndexesResponseGetIndexesResult getIndexesResult;

    public GetIndexesResponse() {
    }

    public GetIndexesResponse(
           org.tempuri.GetIndexesResponseGetIndexesResult getIndexesResult) {
           this.getIndexesResult = getIndexesResult;
    }


    /**
     * Gets the getIndexesResult value for this GetIndexesResponse.
     * 
     * @return getIndexesResult
     */
    public org.tempuri.GetIndexesResponseGetIndexesResult getGetIndexesResult() {
        return getIndexesResult;
    }


    /**
     * Sets the getIndexesResult value for this GetIndexesResponse.
     * 
     * @param getIndexesResult
     */
    public void setGetIndexesResult(org.tempuri.GetIndexesResponseGetIndexesResult getIndexesResult) {
        this.getIndexesResult = getIndexesResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetIndexesResponse)) return false;
        GetIndexesResponse other = (GetIndexesResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getIndexesResult==null && other.getGetIndexesResult()==null) || 
             (this.getIndexesResult!=null &&
              this.getIndexesResult.equals(other.getGetIndexesResult())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getGetIndexesResult() != null) {
            _hashCode += getGetIndexesResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetIndexesResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetIndexesResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getIndexesResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetIndexesResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetIndexesResponse>GetIndexesResult"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
