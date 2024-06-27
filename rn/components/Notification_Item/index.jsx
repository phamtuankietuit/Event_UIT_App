import React from "react";
import { Image, Text, View } from "react-native";
import logo from "../../assets/images/Logo.png"

const Notifi_Item = ({
    item
}) => {
    return (
        <View className={item.read === true ? "h-[90px] bg-white flex items-center flex-row w-full" : "h-[90px] bg-cyan-100 flex items-center flex-row w-full"}>
            <View className="h-[100%] text-wrap w-[20%] flex items-center justify-center">
                <Image
                    source={logo}
                    className="bg-white rounded-full w-[90%] h-[90%] me-4 "
                />
            </View>

            <View className="h-[100%] pt-2 w-[80%]">
                <View className="text-[15px] mb-4 relative">
                    <Text >
                        <Text className="font-semibold">{item.namePage} </Text>
                        {item.des}
                    </Text>
                </View>
                <Text className="text-[13px] ">
                    {item.time}
                </Text>
            </View>


        </View>


    )
}

export default Notifi_Item