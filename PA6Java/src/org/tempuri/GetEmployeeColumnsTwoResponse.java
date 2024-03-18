/**
 * GetEmployeeColumnsTwoResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.tempuri;

public class GetEmployeeColumnsTwoResponse  implements java.io.Serializable {
    private org.tempuri.GetEmployeeColumnsTwoResponseGetEmployeeColumnsTwoResult getEmployeeColumnsTwoResult;

    public GetEmployeeColumnsTwoResponse() {
    }

    public GetEmployeeColumnsTwoResponse(
           org.tempuri.GetEmployeeColumnsTwoResponseGetEmployeeColumnsTwoResult getEmployeeColumnsTwoResult) {
           this.getEmployeeColumnsTwoResult = getEmployeeColumnsTwoResult;
    }


    /**
     * Gets the getEmployeeColumnsTwoResult value for this GetEmployeeColumnsTwoResponse.
     * 
     * @return getEmployeeColumnsTwoResult
     */
    public org.tempuri.GetEmployeeColumnsTwoResponseGetEmployeeColumnsTwoResult getGetEmployeeColumnsTwoResult() {
        return getEmployeeColumnsTwoResult;
    }


    /**
     * Sets the getEmployeeColumnsTwoResult value for this GetEmployeeColumnsTwoResponse.
     * 
     * @param getEmployeeColumnsTwoResult
     */
    public void setGetEmployeeColumnsTwoResult(org.tempuri.GetEmployeeColumnsTwoResponseGetEmployeeColumnsTwoResult getEmployeeColumnsTwoResult) {
        this.getEmployeeColumnsTwoResult = getEmployeeColumnsTwoResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetEmployeeColumnsTwoResponse)) return false;
        GetEmployeeColumnsTwoResponse other = (GetEmployeeColumnsTwoResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getEmployeeColumnsTwoResult==null && other.getGetEmployeeColumnsTwoResult()==null) || 
             (this.getEmployeeColumnsTwoResult!=null &&
              this.getEmployeeColumnsTwoResult.equals(other.getGetEmployeeColumnsTwoResult())));
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
        if (getGetEmployeeColumnsTwoResult() != null) {
            _hashCode += getGetEmployeeColumnsTwoResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetEmployeeColumnsTwoResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">GetEmployeeColumnsTwoResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getEmployeeColumnsTwoResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://tempuri.org/", "GetEmployeeColumnsTwoResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://tempuri.org/", ">>GetEmployeeColumnsTwoResponse>GetEmployeeColumnsTwoResult"));
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
